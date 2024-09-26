using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02
{
    public class MotorElectrico : IMotor
    {
        public void Apagar()
        {
            Console.WriteLine("Apagando motor eléctrico");
        }

        public void Arrancar()
        {
            Console.WriteLine("Arrancando motor eléctrico");
        }
    }
}
