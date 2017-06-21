using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    /// <summary>
    /// Clase que representa los roles de los usuarios
    /// Tabla SQL ROL_USUARIO
    /// </summary>
    public class RolUsuario : BasicDomain
    {
        
        public String nombre {get;set;}
        public String descripcion {get;set;}
    
    }
}
