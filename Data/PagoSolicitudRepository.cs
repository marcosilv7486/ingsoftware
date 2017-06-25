using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Dominio;
namespace Data
{
    public class PagoSolicitudRepository : IPagoSolicitudRepository
    {
        public void registrarPago(PagoSolicitud pago, SqlConnection conexion, SqlTransaction transaccion)
        {
            String nombreProcedure = "REGISTRAR_PAGO";
            SqlCommand comando = new SqlCommand(nombreProcedure, conexion);
            if (transaccion != null)
                comando.Transaction = transaccion;
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@SOLICITUD_ID", SqlDbType.Int).Value = pago.solicitud.id;
            comando.Parameters.AddWithValue("@FORMA_PAGO_ID", SqlDbType.VarChar).Value = pago.formaDePago.id;
            comando.Parameters.AddWithValue("@SERIE", SqlDbType.VarChar).Value = pago.serie;
            comando.Parameters.AddWithValue("@NUMERO", SqlDbType.VarChar).Value = pago.serie;
            comando.Parameters.AddWithValue("@MONTO", SqlDbType.Decimal).Value = pago.monto;
            comando.Parameters.AddWithValue("@FECHA_PAGO", SqlDbType.DateTime).Value = pago.fechaPago ;
            comando.Parameters.AddWithValue("@FOTO_ADJUNTA", SqlDbType.VarChar).Value = pago.fotoAdjunta == null ? "" : pago.fotoAdjunta;
            comando.ExecuteNonQuery();
        }
    }
}
