﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Dominio;
namespace Data
{
    public interface ISolicitudRepository
    {
        void registrarSolicitud(Solicitud solicitud,SqlConnection conexion,SqlTransaction transaccion);
    }
}
