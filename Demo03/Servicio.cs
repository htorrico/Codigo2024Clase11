using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03
{

    //Interfaces: Se implementan funciones
    //Clases: Se heredan propiedades y funciones
    public class Servicio : Descuento, IDescuento
    {
       
        public double AplicarDescuento(int Precio)
        {
            return Precio * 0.2;
        }
    }
}
