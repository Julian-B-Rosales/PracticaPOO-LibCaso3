using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCaso3.Models.Base
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public override string ToString()
        {
            return Apellido + ", " + Nombre;
        }
    }
}
