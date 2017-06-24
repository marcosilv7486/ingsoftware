using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Dominio;
namespace Data
{
    public interface ISolicitudTemaRepository
    {
        void registrarSolicitudTema(SolicitudTema obj, SqlConnection conexion, SqlTransaction transaccion);
    }
}
