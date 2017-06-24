using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Dominio;
namespace Data
{
    public interface IFormaPagoRepository
    {
        List<FormaDePago> obtenerHabilitados(SqlConnection conexion);
    }
}
