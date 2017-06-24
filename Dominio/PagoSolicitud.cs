using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class PagoSolicitud : BasicDomain
    {
        public FormaDePago formaDePago { get; set; }
        public Solicitud solicitud { get; set; }
        public String serie { get; set; }
        public String numero { get; set; }
        public Decimal monto { get; set; }
        public DateTime fechaPago { get; set; }
        public String fotoAdjunta { get; set; }

        public PagoSolicitud()
        {
            formaDePago = new FormaDePago();
            solicitud = new Solicitud();
        }
    }
}
