using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class SolicitudTema : BasicDomain
    {
        public Solicitud solicitud { get; set; }
        public TemaTesis tema { get; set; }

        public SolicitudTema()
        {
            solicitud = new Solicitud();
            tema = new TemaTesis();
        }
    }
}
