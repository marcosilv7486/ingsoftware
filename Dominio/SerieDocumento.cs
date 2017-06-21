using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{   
    /// <summary>
    /// Clase que representa los numero o codigos correlativos de los 
    /// documento en la aplicacion.
    /// </summary>
    public class SerieDocumento :BasicDomain
    {
     
        public String nombreDocumento { get; set; }
        public String serie { get; set; }
        public String numero { get; set; }
     
    }
}
