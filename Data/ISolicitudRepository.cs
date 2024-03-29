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
        List<Solicitud> obtenerPorEstado(int estado_id, SqlConnection conexion);
        void cambiarEstadoPagadoSolicitud(Solicitud solicitud, SolicitudEstado nuevoEstado, 
            SqlConnection conexion, SqlTransaction transaccion);
        void registrarEvaluacionSolicitud(Solicitud solicitud, SolicitudEstado nuevoEstado, SqlConnection conexion,
            SqlTransaction trasaccion);

        bool obtenerSolicitudesSinPagar(int idAlumno, SqlConnection cn, SqlTransaction transaccion);

        bool obtenerSolicitudesEnProceso(int idAlumno, SqlConnection cn, SqlTransaction transaccion);

        void registrarEstadoFinalizado(Solicitud solicitud, SolicitudEstado nuevoEstado, SqlConnection cn, SqlTransaction transaccion);
    }
}
