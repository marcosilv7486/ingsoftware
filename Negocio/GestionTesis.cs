using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio;
using Data;
using System.Data.SqlClient;
using System.IO;
namespace Negocio
{
    public class GestionTesis : IGestionTesis
    {

        private IAlumnoRepository alumnoRepository;
        private ISerieDocumentoRepository serieDocumentoRepository;
        private ISolicitudRepository solicitudRepository;
        private IEstadoSolicitudRepository estadoSolicitudRepository;
        private ITesisTemaRepository tesisTemaRepository;
        private ISolicitudTemaRepository solicitudTemaRepository;
        private IPagoSolicitudRepository pagoSolicitudRepository;
        private IFormaPagoRepository formaPagoRepository;
        private IProfesorRepository profesorRepository;
        public GestionTesis()
        {
            alumnoRepository = new AlumnoRepository();
            serieDocumentoRepository = new SerieDocumentoRepository();
            solicitudRepository = new SolicitudRepository();
            estadoSolicitudRepository = new EstadoSolicitudRepository();
            tesisTemaRepository = new TesisTemaRepository();
            solicitudTemaRepository = new SolicitudTemaRepository();
            pagoSolicitudRepository = new PagoSolicitudRepository();
            formaPagoRepository = new FormaPagoRepository();
            profesorRepository = new ProfesorRepository();
        }

        public List<Alumno> obtenerAlumnosHabilitados()
        {
            SqlConnection cn = null;
            List<Alumno> data = new List<Alumno>();
            try
            {
                cn = HelperDB.GetSqlConnection();
                data = alumnoRepository.obtenerHabilitados(cn).ToList<Alumno>(); ;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (cn != null)
                {
                    cn.Close();
                    cn.Dispose();
                }
            }
            return data;
        }


        public Alumno buscarPorCodigo(string codigo)
        {
            SqlConnection cn = null;
            Alumno alumno = null;
            try
            {
                cn = HelperDB.GetSqlConnection();
                alumno = alumnoRepository.buscarPorCodigo(codigo, cn);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (cn != null)
                {
                    cn.Close();
                    cn.Dispose();
                }
            }
            return alumno;
        }


        public void registrarSolicitud(Solicitud solicitud)
        {
            SqlConnection cn = null;
            SqlTransaction transaccion = null;
            try
            {
                cn = HelperDB.GetSqlConnection();
                //Inicio de la transaccion
                transaccion = cn.BeginTransaction();
                //Verificar si el alumno ya tiene una deuda con la universidad
                bool tieneDeuda = solicitudRepository.obtenerSolicitudesSinPagar(solicitud.alumno.id, cn, transaccion);
                if (tieneDeuda)
                {
                    throw new Exception("El alumno tiene una deuda con la universidad");
                }
                //Verificar si tiene una solicitud en proceso
                bool solicitudEnProceso = solicitudRepository.obtenerSolicitudesEnProceso(solicitud.alumno.id, cn, transaccion);
                if (solicitudEnProceso)
                {
                    throw new Exception("El alumno tiene en proceso una solicitud");
                }
                //Obtener el correlativo del documento y modificarlos
                SerieDocumento serieDocumento = serieDocumentoRepository.obtenerUltimo("SOLICITUD", cn, transaccion);
                if (serieDocumento == null)
                    throw new ArgumentNullException("No se encontro la serie para la solicitud");
                String strNumero = String.Format("{0:D8}", int.Parse(serieDocumento.numero) + 1);
                serieDocumento.numero = strNumero;
                serieDocumentoRepository.modificar(serieDocumento, cn, transaccion);
                //Asociar el correlativo
                solicitud.codigo = serieDocumento.serie + "-" + strNumero;
                //Obtener El estado GENERADO
                SolicitudEstado estadoGenerado = estadoSolicitudRepository.obtenerPorId(1, cn, transaccion);
                if (estadoGenerado == null)
                    throw new ArgumentNullException("No se encontro el estado GENERADO para la solicitud");
                solicitud.estadoSolicitud = estadoGenerado;
                solicitud.nombreEstado = estadoGenerado.nombre;
                solicitudRepository.registrarSolicitud(solicitud, cn, transaccion);
                //Registrar los temas de la solicitud
                foreach (SolicitudTema tema in solicitud.temas)
                {
                    tema.solicitud = solicitud;
                    solicitudTemaRepository.registrarSolicitudTema(tema, cn, transaccion);
                }
                transaccion.Commit();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                transaccion.Rollback();
                throw new Exception(e.Message);
            }
            finally
            {
                if (cn != null)
                {
                    cn.Close();
                    cn.Dispose();
                }
            }
        }


        public List<TemaTesis> obtenerTesisHabilitadas()
        {

            SqlConnection cn = null;
            List<TemaTesis> data = new List<TemaTesis>();
            try
            {
                cn = HelperDB.GetSqlConnection();
                data = tesisTemaRepository.obtenerHabilitados(cn);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (cn != null)
                {
                    cn.Close();
                    cn.Dispose();
                }
            }
            return data;
        }


        public List<Solicitud> obtenerSolicitudesPendientesPago()
        {
            SqlConnection cn = null;
            List<Solicitud> data = new List<Solicitud>();
            try
            {
                cn = HelperDB.GetSqlConnection();
                //1-GENERADO
                data = solicitudRepository.obtenerPorEstado(1, cn);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (cn != null)
                {
                    cn.Close();
                    cn.Dispose();
                }
            }
            return data;
        }


        public void registrarPagoSolicitud(PagoSolicitud pagoSolicitud)
        {
            SqlConnection cn = null;
            SqlTransaction transaccion = null;
            try
            {
                cn = HelperDB.GetSqlConnection();
                //Inicio de la transaccion
                transaccion = cn.BeginTransaction();
                //Estado 3= Cancelado
                SolicitudEstado estadoPagado = estadoSolicitudRepository.obtenerPorId(3, cn, transaccion);
                if (estadoPagado == null)
                    throw new ArgumentNullException("No se encontro el estado PAGADO para la solicitud");
                pagoSolicitudRepository.registrarPago(pagoSolicitud, cn, transaccion);
                //Modificar el estado de la solicitud
                solicitudRepository.cambiarEstadoPagadoSolicitud(pagoSolicitud.solicitud, estadoPagado, cn, transaccion);
                transaccion.Commit();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                transaccion.Rollback();
                throw new Exception(e.Message);
            }
            finally
            {
                if (cn != null)
                {
                    cn.Close();
                    cn.Dispose();
                }
            }
        }


        public List<FormaDePago> obtenerFormasPagoHabilitadas()
        {
            SqlConnection cn = null;
            List<FormaDePago> data = new List<FormaDePago>();
            try
            {
                cn = HelperDB.GetSqlConnection();
                data = formaPagoRepository.obtenerHabilitados(cn);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (cn != null)
                {
                    cn.Close();
                    cn.Dispose();
                }
            }
            return data;
        }


        public List<Solicitud> obtenerSolicitudPorEstado(int idEstado)
        {
            SqlConnection cn = null;
            List<Solicitud> data = new List<Solicitud>();
            try
            {
                cn = HelperDB.GetSqlConnection();
                data = solicitudRepository.obtenerPorEstado(idEstado, cn);
                foreach (Solicitud solicitud in data)
                {
                    solicitud.temas = solicitudTemaRepository.obtenerTemasPorSolicitud(solicitud, cn);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (cn != null)
                {
                    cn.Close();
                    cn.Dispose();
                }
            }
            return data;
        }


        public void registrarEvaluacionSolicitud(Solicitud solicitud)
        {
            SqlConnection cn = null;
            SqlTransaction transaccion = null;
            try
            {
                cn = HelperDB.GetSqlConnection();
                //Inicio de la transaccion
                transaccion = cn.BeginTransaction();
                //Estado 5= Aprobado , 4 Desaprobado
                SolicitudEstado nuevoEstado = estadoSolicitudRepository.obtenerPorId(solicitud.aprobado ? 5 : 4, cn, transaccion);
                if (nuevoEstado == null)
                    throw new ArgumentNullException("No se encontro el estado APROBADO/DESAPROBADO para la solicitud");
                solicitudRepository.registrarEvaluacionSolicitud(solicitud, nuevoEstado, cn, transaccion);
                transaccion.Commit();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                transaccion.Rollback();
                throw new Exception(e.Message);
            }
            finally
            {
                if (cn != null)
                {
                    cn.Close();
                    cn.Dispose();
                }
            }
        }


        public System.Data.DataSet obtenerTodos()
        {
            SqlConnection cn = null;
            System.Data.DataSet dataSet = new System.Data.DataSet();
            try
            {
                cn = HelperDB.GetSqlConnection();
                dataSet = alumnoRepository.obtenerTodos(cn);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (cn != null)
                {
                    cn.Close();
                    cn.Dispose();
                }
            }
            return dataSet;
        }


        public List<Profesor> obtenerProfesoresHabilitados()
        {
            SqlConnection cn = null;
            List<Profesor> data = new List<Profesor>();
            try
            {
                cn = HelperDB.GetSqlConnection();
                data = profesorRepository.obtenerHabilitados(cn);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (cn != null)
                {
                    cn.Close();
                    cn.Dispose();
                }
            }
            return data;
        }
    }

       
}







