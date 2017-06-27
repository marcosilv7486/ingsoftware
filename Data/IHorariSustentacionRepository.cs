using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio;
using System.Data.SqlClient;
namespace Data
{
    public interface IHorariSustentacionRepository
    {
        void registrarHorario(HorarioSustentacion horario, SqlConnection cn, SqlTransaction transaccion);
    }
}
