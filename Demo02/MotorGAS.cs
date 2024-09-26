using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02
{
    public class MotorGAS : IMotor
    {
        public void Apagar()
        {
            Console.WriteLine("Apagando motor a GAS");
        }

        public void Arrancar()
        {
            Console.WriteLine("Arrancando motor a GAS");
            
        }
    }
}
