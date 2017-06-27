using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio;
using System.Data.SqlClient;
namespace Data
{
    public class HorariSustentacionRepository : IHorariSustentacionRepository
    {
        public void registrarHorario(HorarioSustentacion horario, SqlConnection cn, SqlTransaction transaccion)
        {
            String nombreProcedure = "HORARIO_JURADO_SUSTENTACION";
            SqlCommand comando = new SqlCommand(nombreProcedure, cn);
            if (transaccion != null)
                comando.Transaction = transaccion;
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@SOLICITUD_ID", horario.solicitud.id);
            comando.Parameters.AddWithValue("@PROFESOR_ID", horario.profesor.id);
            comando.Parameters.AddWithValue("@LUGAR", horario.lugar);
            comando.Parameters.AddWithValue("@FECHA", horario.fecha);
            comando.Parameters.AddWithValue("@HORA", horario.hora);
            comando.Parameters.AddWithValue("@FECHA_FIN", horario.fechaFin);
            comando.ExecuteNonQuery();
        }
    }
}
