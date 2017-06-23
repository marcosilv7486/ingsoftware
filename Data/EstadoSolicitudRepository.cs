using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio;
using System.Data.SqlClient;
using System.Data;

namespace Data
{
    public class EstadoSolicitudRepository : IEstadoSolicitudRepository
    {
        public SolicitudEstado obtenerPorId(int id, SqlConnection conexion)
        {
            String nombreProcedure = "OBTENER_ESTADOSOLICITUD_POR_ID";
            SqlCommand comando = new SqlCommand(nombreProcedure, conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@ID", SqlDbType.Int).Value = id;
            SqlDataReader lector = comando.ExecuteReader();
            SolicitudEstado data = null;
            while (lector.HasRows)
            {
                data = new SolicitudEstado();
                data.id = int.Parse(lector["ID"].ToString());
                data.nombre = lector["NOMBRE"].ToString();
                break;
            }
            lector.Close();
            lector.Dispose();
            comando.Dispose();
            return data;
        }
    }
}
