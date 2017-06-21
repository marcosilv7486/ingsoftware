using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    /// <summary>
    /// Clase que representa al Usuario
    /// Tabla Sql USUARIO
    /// </summary>
    public class Usuario : BasicDomain
    {
        
        public String username{ get; set; }
        public String password { get; set; }
        public String correo { get; set; }
        public String apellidos { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public String urlAvatar { get; set; }
        public String telefono { get; set; }
        public bool habilitado { get; set; }

        public RolUsuario rol { get; set; }

        public Usuario()
        {
            rol = new RolUsuario();
        }
    }
}
