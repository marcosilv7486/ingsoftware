using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio;
using System.Data.SqlClient;
namespace Data
{
    public interface IAlumnoRepository
    {
        ICollection<Alumno> obtenerHabilitados(SqlConnection conexion);
        Alumno buscarPorId(int id, SqlConnection conexion);
        Alumno buscarPorCodigo(String codigo,SqlConnection conexion);
        ICollection<Alumno> obtenerTodos(SqlConnection conexion);
    }
}
