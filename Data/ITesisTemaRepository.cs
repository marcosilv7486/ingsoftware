using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Dominio;
using System.Data.SqlClient;
namespace Data
{
    public interface ITesisTemaRepository
    {
        List<TemaTesis> obtenerHabilitados(SqlConnection conexion);
    }
}
