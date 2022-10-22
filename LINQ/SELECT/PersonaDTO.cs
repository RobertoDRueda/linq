using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SELECT
{
    public class PersonaDTO
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Edad: {Edad}";
        }
    }
}
