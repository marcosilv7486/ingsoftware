using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio;
using System.Data.SqlClient;
namespace Data
{
    public interface ISerieDocumentoRepository
    {
        SerieDocumento obtenerUltimo(String tipo,SqlConnection conexion);
        void modificar(SerieDocumento serieDocumento,SqlConnection conexion,SqlTransaction transaccion);
    }
}
