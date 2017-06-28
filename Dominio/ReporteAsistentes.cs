using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class ReporteAsistentes
    {
        public Solicitud solicitud { get; set; }
        public String lugar { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public int duracion { get; set; }

        public List<MiembroJurado> miembros { get; set; }

        public ReporteAsistentes()
        {
            miembros = new List<MiembroJurado>();
        }
        
    }
}
