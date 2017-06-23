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
    }
}
