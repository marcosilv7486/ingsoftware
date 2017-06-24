using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Dominio;
namespace Data
{
    public class FormaPagoRepository : IFormaPagoRepository
    {
        public List<FormaDePago> obtenerHabilitados(SqlConnection conexion)
        {
            String nombreProcedure = "OBTENER_FORMA_PAGO_HABILITADOS";
            SqlCommand comando = new SqlCommand(nombreProcedure, conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader lector = comando.ExecuteReader();
            List<FormaDePago> data = new List<FormaDePago>();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    FormaDePago forma = new FormaDePago();
                    forma.id = int.Parse(lector["ID"].ToString());
                    forma.nombre = lector["NOMBRE"].ToString();
                    data.Add(forma);
                }
            }
            lector.Close();
            lector.Dispose();
            comando.Dispose();
            return data;
        }
    }
}
