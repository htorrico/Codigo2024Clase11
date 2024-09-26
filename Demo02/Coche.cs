using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02
{
    public class Coche : Vehiculo
    {
        public override void Acelerar(int incremento)
        {
            Console.WriteLine($"El coche incrementó en {incremento} km/h.");
        }

        public override void Encender()
        {
            Console.WriteLine("El coche está encendido.");
        }
    }
}
