

using Demo03;

List<IDescuento> descuentos = new List<IDescuento>();

descuentos.Add(new Producto { PrecioFinal=200});
descuentos.Add(new Servicio{ PrecioFinal=400});


foreach (var item in descuentos)
{    
    Console.WriteLine(item.AplicarDescuento(500));
}

Console.ReadLine();