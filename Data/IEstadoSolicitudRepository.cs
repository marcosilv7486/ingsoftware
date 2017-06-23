using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio;
using System.Data.SqlClient;
namespace Data
{
    public interface IEstadoSolicitudRepository
    {
        SolicitudEstado obtenerPorId(int id, SqlConnection conexion);
    }
}
