using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Dominio;
namespace Data
{
    public class SolicitudRepository  : ISolicitudRepository
    {
        public void registrarSolicitud(Solicitud solicitud, System.Data.SqlClient.SqlConnection conexion,SqlTransaction transaccion)
        {
            String nombreProcedure = "REGISTRAR_SOLICITUD";
            SqlCommand comando = new SqlCommand(nombreProcedure, conexion);
            if (transaccion != null)
                comando.Transaction = transaccion;
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@CODIGO", solicitud.codigo);
            comando.Parameters.AddWithValue("@FECHA_EMISION", solicitud.fechaEmision);
            comando.Parameters.AddWithValue("@CODIGO_ALUMNO", solicitud.codigoAlumnoSol);
            comando.Parameters.AddWithValue("@NOMBRES_SOL", solicitud.nombreSol);
            comando.Parameters.AddWithValue("@APELLIDOS_SOL", solicitud.apellidosSol);
            comando.Parameters.AddWithValue("@TIPO_DOCUMENTO_SOL", solicitud.tipoDocumentoSol);
            comando.Parameters.AddWithValue("@NUMERO_DOCUMENTO_SOL", solicitud.numeroDocumentoSol);
            comando.Parameters.AddWithValue("@GRADO_ACADEMICO_SOL", solicitud.gradoAcademicoSol);
            comando.Parameters.AddWithValue("@PROGRAMA_POSTGRADO", solicitud.programaPostGrado);
            comando.Parameters.AddWithValue("@NOMBRE_TESIS", solicitud.nombreTesis);
            comando.Parameters.AddWithValue("@OBSERVACIONES", solicitud.observaciones);
            comando.Parameters.AddWithValue("@ALUMNO_ID", solicitud.alumno.id);
            comando.Parameters.AddWithValue("@SOLICITUD_ESTADO_ID", solicitud.estadoSolicitud.id);
            comando.Parameters.AddWithValue("@NOMBRE_ESTADO", solicitud.nombreEstado);
            comando.Parameters.Add("@ID", SqlDbType.Int);
            comando.Parameters["@ID"].Direction = ParameterDirection.Output;
            comando.ExecuteNonQuery();
            solicitud.id = int.Parse(comando.Parameters["@ID"].Value.ToString());
        }


        public List<Solicitud> obtenerPorEstado(int estado_id, SqlConnection conexion)
        {
            List<Solicitud> data = new List<Solicitud>();
            String nombreProcedure = "OBTENER_SOLICITUDES_POR_ESTADO";
            SqlCommand comando = new SqlCommand(nombreProcedure, conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@ESTADO_ID", estado_id);
            SqlDataReader lector = comando.ExecuteReader();
            data = mapearSolicitudListado(lector);
            lector.Close();
            lector.Dispose();
            comando.Dispose();
            return data;
        }

        private List<Solicitud> mapearSolicitudListado(SqlDataReader lector)
        {
            List<Solicitud> data = new List<Solicitud>();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Solicitud solicitud = new Solicitud();
                    solicitud.id = int.Parse(lector["ID"].ToString());
                    solicitud.codigo = lector["CODIGO"].ToString();
                    solicitud.fechaEmision = DateTime.Parse(lector["FECHA_EMISION"].ToString());
                    solicitud.codigoAlumnoSol = lector["CODIGO_ALUMNO_SOL"].ToString();
                    solicitud.nombreSol = lector["NOMBRES_SOL"].ToString();
                    solicitud.apellidosSol = lector["APELLIDOS_SOL"].ToString();
                    solicitud.numeroDocumentoSol = lector["NUMERO_DOCUMENTO_SOL"].ToString();
                    solicitud.nombreTesis = lector["NOMBRE_TESIS"].ToString();
                    solicitud.nombreEstado = lector["NOMBRE_ESTADO"].ToString();
                    if (!lector.IsDBNull(9))
                    {
                        solicitud.fechaPago = DateTime.Parse(lector["FECHA_PAGO"].ToString());
                    }
                    if (!lector.IsDBNull(10))
                    {
                        solicitud.fechaEvaluacion = DateTime.Parse(lector["FECHA_EVALUACION"].ToString());
                    }
                    if (!lector.IsDBNull(11))
                    {
                        solicitud.fechaFinalizacion = DateTime.Parse(lector["FECHA_FINALIZACION"].ToString());
                    }
                    solicitud.programaPostGrado = lector["PROGRAMA_POSTGRADO"].ToString();
                    data.Add(solicitud);
                }
                return data;
            }
            else
            {
                return data;
            }
        }
    }
}
