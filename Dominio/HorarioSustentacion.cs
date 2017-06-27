using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class HorarioSustentacion : BasicDomain
    {
        public Solicitud solicitud { get; set; }
        public Profesor profesor { get; set; }
        public Boolean esPresidente { get; set; }
        public String lugar { get; set; }
        public DateTime fecha { get; set; }
        public DateTime hora { get; set; }
        public DateTime fechaFin { get; set; }
        public HorarioSustentacion()
        {
            solicitud = new Solicitud();
            profesor = new Profesor();
        }
    }
}
