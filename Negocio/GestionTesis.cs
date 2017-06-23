using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio;
using Data;
using System.Data.SqlClient;
namespace Negocio
{
    public class GestionTesis : IGestionTesis
    {

        private IAlumnoRepository alumnoRepository;
        private ISerieDocumentoRepository serieDocumentoRepository;
        private ISolicitudRepository solicitudRepository;
        private IEstadoSolicitudRepository estadoSolicitudRepository;

        public GestionTesis()
        {
            alumnoRepository = new AlumnoRepository();
            serieDocumentoRepository = new SerieDocumentoRepository();
            solicitudRepository = new SolicitudRepository();
            estadoSolicitudRepository = new EstadoSolicitudRepository();
        }
        
        public List<Alumno> obtenerAlumnosHabilitados()
        {
            SqlConnection cn=null;
            List<Alumno> data = new List<Alumno>();
            try
            {
                cn = HelperDB.GetSqlConnection();
                data = alumnoRepository.obtenerHabilitados(cn).ToList<Alumno>();;
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
                alumno = alumnoRepository.buscarPorCodigo(codigo,cn) ;
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
                SerieDocumento serieDocumento = serieDocumentoRepository.obtenerUltimo("Solicitud", cn);
                if (serieDocumento == null)
                    throw new ArgumentNullException("No se encontro la serie para la solicitud");
                transaccion = cn.BeginTransaction();
                solicitudRepository.registrarSolicitud(solicitud, cn, transaccion);
                serieDocumentoRepository.modificar(serieDocumento, cn,transaccion);
                transaccion.Commit();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                transaccion.Rollback();
                throw new Exception(e.Message);
            } 
        }
    }
}
