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
            comando.Parameters.AddWithValue("@CODIGO", SqlDbType.VarChar).Value = solicitud.codigo;
            comando.Parameters.AddWithValue("@FECHA_EMISION", SqlDbType.Date).Value = solicitud.fechaEmision;
            comando.Parameters.AddWithValue("@CODIGO_ALUMNO", SqlDbType.VarChar).Value = solicitud.codigoAlumnoSol;
            comando.Parameters.AddWithValue("@NOMBRES_SOL", SqlDbType.VarChar).Value = solicitud.nombreSol;
            comando.Parameters.AddWithValue("@APELLIDOS_SOL", SqlDbType.VarChar).Value = solicitud.apellidosSol;
            comando.Parameters.AddWithValue("@TIPO_DOCUMENTO_SOL", SqlDbType.VarChar).Value = solicitud.tipoDocumentoSol;
            comando.Parameters.AddWithValue("@NUMERO_DOCUMENTO_SOL", SqlDbType.VarChar).Value = solicitud.numeroDocumentoSol;
            comando.Parameters.AddWithValue("@GRADO_ACADEMICO_SOL", SqlDbType.VarChar).Value = solicitud.gradoAcademicoSol;
            comando.Parameters.AddWithValue("@PROGRAMA_POSTGRADO", SqlDbType.VarChar).Value = solicitud.programaPostGrado;
            comando.Parameters.AddWithValue("@NOMBRE_TESIS", SqlDbType.VarChar).Value = solicitud.nombreTesis;
            comando.Parameters.AddWithValue("@OBSERVACIONES", SqlDbType.VarChar).Value = solicitud.observaciones;
            comando.Parameters.AddWithValue("@ALUMNO_ID", SqlDbType.Int).Value = solicitud.alumno.id;
            comando.Parameters.AddWithValue("@SOLICITUD_ESTADO_ID", SqlDbType.Int).Value = solicitud.estadoSolicitud.id;
            comando.ExecuteNonQuery();
        }
    }
}
