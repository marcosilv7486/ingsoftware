using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class TemaTesis : BasicDomain
    {
        public String nombre { set; get; }

        public override string ToString()
        {
            return nombre;
        }
    }
}
