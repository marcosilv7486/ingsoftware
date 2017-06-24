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
        public SolicitudEstado obtenerPorId(int id, SqlConnection conexion,SqlTransaction transaccion)
        {
            String nombreProcedure = "OBTENER_ESTADOSOLICITUD_POR_ID";
            SqlCommand comando = new SqlCommand(nombreProcedure, conexion);
            if (transaccion != null)
                comando.Transaction = transaccion;
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@ID", SqlDbType.Int).Value = id;
            SqlDataReader lector = comando.ExecuteReader();
            SolicitudEstado data = null;
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    data = new SolicitudEstado();
                    data.id = int.Parse(lector["ID"].ToString());
                    data.nombre = lector["NOMBRE"].ToString();
                    break;
                }
            }
            else
            {
                return null;
            }
            lector.Close();
            lector.Dispose();
            comando.Dispose();
            return data;
        }
    }
}
