using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Dominio;
namespace Data
{
    public class SolicitudTemaRepository : ISolicitudTemaRepository
    {

        public void registrarSolicitudTema(SolicitudTema obj, SqlConnection conexion, SqlTransaction transaccion)
        {
            String nombreProcedure = "REGISTRAR_SOLICITUD_TEMA";
            SqlCommand comando = new SqlCommand(nombreProcedure, conexion);
            if (transaccion != null)
                comando.Transaction = transaccion;
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@SOLICITUD_ID", obj.solicitud.id);
            comando.Parameters.AddWithValue("@TEMA_ID", obj.tema.id);
            comando.ExecuteNonQuery();
        }


        public List<SolicitudTema> obtenerTemasPorSolicitud(Solicitud obj, SqlConnection conexion)
        {
            String nombreProcedure = "OBTENER_TEMAS_POR_SOLICITUD";
            SqlCommand comando = new SqlCommand(nombreProcedure, conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@SOLICITUD_ID", obj.id);
            SqlDataReader lector = comando.ExecuteReader();
            List<SolicitudTema> data = new List<SolicitudTema>();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    SolicitudTema tesis = new SolicitudTema();
                    tesis.tema.nombre = lector["NOMBRE"].ToString();
                    data.Add(tesis);
                }
            }
            lector.Close();
            lector.Dispose();
            comando.Dispose();
            return data;
        }
    }
}
