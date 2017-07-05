using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class Solicitud : BasicDomain
    {
        public String codigo { get; set; }
        public DateTime fechaEmision { get; set; }
        public String codigoAlumnoSol { get; set; }
        public String nombreSol { get; set; }
        public String apellidosSol { get; set; }
        public String tipoDocumentoSol { get; set; }
        public String numeroDocumentoSol { get; set; }
        public String gradoAcademicoSol { get; set; }
        public String programaPostGrado { get; set; }
        public String nombreTesis { get; set; }
        public String observaciones { get; set; }
        public Alumno alumno { get; set; }
        public SolicitudEstado estadoSolicitud { get; set; }
        public String nombreEstado { get; set; }
        public DateTime? fechaPago { get; set; }
        public DateTime? fechaEvaluacion { get; set; }
        public String motivoEvaluacion { get; set; }
        public String motivoAnulacion { get; set; }
        public String motivoDesaprobacion { get; set; }
        public DateTime? fechaFinalizacion { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public int duracion { get; set; }
        public String lugar { get; set; }
        public String urlTesis { get; set; }
        public String nombreArchivo { get; set; }
        public String carpetaArchivo { get; set; }

        public bool aprobado { get; set; }

        public List<SolicitudTema> temas { get; set; }

        public String nombreCompleto()
        {
            return nombreSol + " " + apellidosSol;
        }

        public Solicitud()
        {
            alumno =  new Alumno();
            estadoSolicitud = new SolicitudEstado();
            temas = new List<SolicitudTema>();
        }
    }
}
