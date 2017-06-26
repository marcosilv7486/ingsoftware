using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Dominio;
namespace Dominio
{
    public interface IProfesorRepository
    {
        List<Profesor> obtenerHabilitados(SqlConnection conexion);
    }
}
