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
    }
}
