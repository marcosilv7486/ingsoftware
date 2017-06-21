using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Data
{   
    /// <summary>
    /// Clase utilitaria para realizar la conexion a la base de datos
    /// </summary>
    public class HelperDB
    {   
        /// <summary>
        /// Metodo utilitario que devuelve la conexion a SQLSERVER , si la conexion esta cerrada la abrirá.
        /// </summary>
        /// <returns>SqlConnection</returns>
        public static SqlConnection GetSqlConnection()
        {
            string connectionString = "Provider=SQLNCLI10;Server=.;Database=BD_TESIS;Uid=sa;Pwd=sql";
            var connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
