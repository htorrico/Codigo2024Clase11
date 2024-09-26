using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02
{
    //Interfaces: También se les conoce como contrato
    public interface IMotor
    {
        public void Arrancar();//Firma
        public void Apagar();//Firma
       
    }
}
