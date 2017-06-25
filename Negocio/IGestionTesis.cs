using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio;
namespace Negocio
{
    public interface IGestionTesis
    {
        List<Alumno> obtenerAlumnosHabilitados();
        Alumno buscarPorCodigo(String codigo);
        void registrarSolicitud(Solicitud solicitud);
        List<TemaTesis> obtenerTesisHabilitadas();
        List<Solicitud> obtenerSolicitudesPendientesPago();
        List<Solicitud> obtenerSolicitudPorEstado(int idEstado);
        void registrarPagoSolicitud(PagoSolicitud pagoSolicitud);
        List<FormaDePago> obtenerFormasPagoHabilitadas();
    }
}
