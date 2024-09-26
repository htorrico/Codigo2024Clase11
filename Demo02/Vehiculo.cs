using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02
{
    public abstract class Vehiculo
    {
        public abstract void Encender();
        public abstract void Acelerar(int incremento);
        
        public void Mostrar()
        {
            Console.WriteLine("Función Mostrar");
        }
    }
}
