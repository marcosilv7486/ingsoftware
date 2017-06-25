using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Estandar
{
    public class Utilitario
    {   

        public String directorioFotos;
        private static Utilitario instancia;

        private Utilitario()
        {
            directorioFotos=Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            directorioFotos = Path.Combine(directorioFotos, "Resources");
            directorioFotos = Path.Combine(directorioFotos, "Alumnos");
            directorioFotos = directorioFotos + Path.DirectorySeparatorChar;
        }

        public static Utilitario getInstance()
        {
            if (instancia == null)
            {
                instancia = new Utilitario();
            }
            return instancia;
                
        }
    }
}
