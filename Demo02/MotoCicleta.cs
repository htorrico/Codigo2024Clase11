using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02
{
    public class MotoCicleta : IBicicleta, IMotor
    {
        public void Acelerar(int incremento)
        {
            Console.WriteLine($"La MotoCicleta incrementó en {incremento} km/h.");
        }

        public void Apagar()
        {
            Console.WriteLine("Apagando la bicicleta");
        }

        public void Arrancar()
        {
            Console.WriteLine("La MotoCicleta está arrancando.");
        }

          
    }
}
