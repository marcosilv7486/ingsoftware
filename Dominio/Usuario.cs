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
    public class Usuario
    {
        public int id { get; set; }
        public String username{ get; set; }
        public String password { get; set; }
        public String correo { get; set; }
        public String apellidos { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public String urlAvatar { get; set; }
        public String telefono1 { get; set; }
        public String telefono2 { get; set; }
        public bool habilitado { get; set; }
        public DateTime fechaRegistro { get; set; }
        public bool eliminado { get; set; }

        public RolUsuario rol { get; set; }

        public Usuario()
        {
            rol = new RolUsuario();
        }
    }
}
