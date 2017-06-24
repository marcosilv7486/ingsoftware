using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Dominio;
namespace Data
{
    public class SerieDocumentoRepository : ISerieDocumentoRepository
    {
        public Dominio.SerieDocumento obtenerUltimo(string tipo, System.Data.SqlClient.SqlConnection conexion,SqlTransaction transaccion)
        {
            String nombreProcedure = "ULTIMO_NUMERO_SERIE";
            SqlCommand comando = new SqlCommand(nombreProcedure, conexion);
            if (transaccion != null)
                comando.Transaction = transaccion;
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@tipo", SqlDbType.VarChar).Value = tipo;
            SqlDataReader lector = comando.ExecuteReader();
            SerieDocumento data = null;
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    data = new SerieDocumento();
                    data.id = int.Parse(lector["ID"].ToString());
                    data.serie = lector["SERIE"].ToString();
                    data.numero = lector["NUMERO"].ToString();
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

        public void modificar(Dominio.SerieDocumento serieDocumento, System.Data.SqlClient.SqlConnection conexion, SqlTransaction transaccion)
        {
            String nombreProcedure = "MODIFICAR_NUMERO_SERIE";
            SqlCommand comando = new SqlCommand(nombreProcedure, conexion);
            if (transaccion != null)
                comando.Transaction = transaccion;
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@ID", SqlDbType.Int).Value = serieDocumento.id;
            comando.Parameters.AddWithValue("@SERIE", SqlDbType.VarChar).Value = serieDocumento.serie;
            comando.Parameters.AddWithValue("@NUMERO", SqlDbType.VarChar).Value = serieDocumento.numero;
            comando.ExecuteNonQuery();
        }
    }
}
