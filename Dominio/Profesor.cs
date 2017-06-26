using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class Profesor : BasicDomain
    {
        public String codigo { get; set; }
        public String nombres { get; set; }
        public String apellidos { get; set; }
        public String maestria { get; set; }
        public String doctorado { get; set; }
        public String observaciones { get; set; }
        public String telefono { get; set; }
        public String correo { get; set; }
        public String urlFoto { get; set; }
       
    }
}
