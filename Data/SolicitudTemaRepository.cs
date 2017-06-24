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
    }
}
