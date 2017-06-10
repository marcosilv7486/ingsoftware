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
    public class SerieDocumento
    {
        public int id { get; set; }
        public String nombreDocumento { get; set; }
        public String serie { get; set; }
        public String numero { get; set; }
        public DateTime fechaRegistro { get; set; }
        public bool eliminado { get; set; }
    }
}
