using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03
{
    public class Producto: Descuento, IDescuento
    {        
        public double AplicarDescuento(int Precio)
        {
            return Precio * 0.1;
        }
    }
}
