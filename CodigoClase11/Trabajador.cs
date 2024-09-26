using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase11
{
    public class Trabajador
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NumeroDocumento { get; set; }
        public int Sueldo { get; set; }

        public double CalcularDescuento()
        {
            return Sueldo * 0.05;
        }
    }
}
