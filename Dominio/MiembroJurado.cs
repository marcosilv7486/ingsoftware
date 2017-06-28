using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class MiembroJurado
    {
        public String codigo { get; set; }
        public String nombreCompleto { get; set; }
        public String maestria { get; set; }
        public String doctorado { get; set; }
        public bool jurado { get; set; }
    }
}
