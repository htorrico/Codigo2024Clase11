

using CodigoClase11;


void EstudiantesCursos()
{
    Estudiante estudiante = new Estudiante
    {
        Apellidos = "Sosa",
        Nombres = "Edson",
        Codigo = "20054124",
        Cursos = new List<Curso>()
    };

    estudiante.Cursos.Add(new Curso
    {
        Nombre = "Matemática",
        Descripcion = "Descripción cualquiera",
        Creditos = 5
    });
    estudiante.Cursos.Add(new Curso
    {
        Nombre = "Historia",
        Descripcion = "Descripción cualquiera",
        Creditos = 4
    });
    estudiante.Cursos.Add(new Curso
    {
        Nombre = "Religión",
        Descripcion = "Descripción cualquiera",
        Creditos = 3
    });
    estudiante.Cursos.Add(new Curso
    {
        Nombre = "Biología",
        Descripcion = "Descripción cualquiera",
        Creditos = 5
    });


    foreach (var item in estudiante.Cursos)
    {
        Console.WriteLine(item.Nombre);

    }
}

//Instancia=>Objeto=>New
Empresa empresa = new Empresa
{
    Nombre = "Codigo",
    Direccion = "Lima",
    Trabajadores = new List<Trabajador>()
};

empresa.Trabajadores.Add(new Trabajador
{
    Apellidos = "Torrico",
    Nombres = "Hugo",
    NumeroDocumento = "11111",
    Sueldo = 5000
});

empresa.Trabajadores.Add(new Trabajador
{
    Apellidos = "Marquez",
    Nombres = "Felipe",
    NumeroDocumento = "11111",
    Sueldo = 3000
});


foreach (var trabajador in empresa.Trabajadores)
{
    Console.WriteLine(trabajador.Nombres);
    Console.WriteLine(trabajador.Sueldo);
    Console.WriteLine(trabajador.CalcularDescuento());
}



Console.Read();