using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Dominio;
using System.Data.SqlClient;
namespace Data
{
    public class TesisTemaRepository : ITesisTemaRepository
    {

        public List<TemaTesis> obtenerHabilitados(SqlConnection conexion)
        {
            String nombreProcedure = "OBTENER_TEMA_TESIS_HABILITADOS";
            SqlCommand comando = new SqlCommand(nombreProcedure, conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader lector = comando.ExecuteReader();
            List<TemaTesis> data = mapearTesis(lector);
            lector.Close();
            lector.Dispose();
            comando.Dispose();
            return data;
        }

        private List<TemaTesis> mapearTesis(SqlDataReader lector)
        {
            List<TemaTesis> data = new List<TemaTesis>();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    TemaTesis tesis = new TemaTesis();
                    tesis.id = int.Parse(lector["ID"].ToString());
                    tesis.nombre = lector["NOMBRE"].ToString();
                    data.Add(tesis);
                }
            }
            return data;
        }
    }
}
