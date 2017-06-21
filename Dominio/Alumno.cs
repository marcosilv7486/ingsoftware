using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class Alumno : BasicDomain
    {

        public String codigo {get;set;}
        public String nombre {get;set;}
        public String apellidos {get;set;}
        public String correo {get;set;}
        public DateTime fechaNacimiento {get;set;}
        public String planCurricular {get;set;}
        public String tipoDocumento {get;set;}
        public String numeroDocumento {get;set;}
        public String gradoAcademico {get;set;}
        public ProgramaPostGrado programaPostGrado;
        public String urlFoto {get;set;}

        public Alumno()
        {
            programaPostGrado = new ProgramaPostGrado();
        }
    }
}
