using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{   
    /// <summary>
    /// Clase que continiene todos los atributos genericos para 
    /// cada objetivo de dominio.
    /// </summary>
    public class BasicDomain
    {
        /// <summary>
        /// Id 
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// Fecha de creacion del registro
        /// </summary>
        public DateTime fechaRegistro { get; set; }
        /// <summary>
        /// Indicado si esta eliminado
        /// </summary>
        public bool eliminado { get; set; }
    }
}
