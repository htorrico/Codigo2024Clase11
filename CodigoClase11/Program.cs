

using CodigoClase11;

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




//Estudiante estudiante = new Estudiante
//{
//    Apellidos = "Sosa",
//    Nombres = "Edson",
//    Codigo = "20054124",
//    Curso = new Curso
//    {
//        Nombre = "Matemática",
//        Descripcion = "Descripción cualquiera",
//        Creditos = 5
//    },
//    Curso2= new Curso
//    {
//         Nombre="Historia",
//          Descripcion="Descripcion",
//           Creditos=4
//    }

//};

//Console.WriteLine(estudiante.Curso.Nombre);
//Console.WriteLine(estudiante.Curso2.Nombre);

Console.Read();