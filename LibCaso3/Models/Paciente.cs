using LibCaso3.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCaso3.Models
{
    public class Paciente : Persona
    {
        public string dni { get; set; }
        public override string ToString()
        {
            return base.ToString() + " - DNI: " + dni;
        }
    }
}
