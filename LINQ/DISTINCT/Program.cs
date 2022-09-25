
using ANY;

int[] numeros = { 1, 2, 3, 1, 1, 5 };

var numerosSinRepeticiones = numeros.Distinct().ToArray();

Console.WriteLine("numerosSinRepeticiones");
foreach (var num in numerosSinRepeticiones)
{
    Console.WriteLine(num);
}

List<List<int>> listaNumeros = new List<List<int>>
{
    new List<int> { 1,2,3,4},
    new List<int> {1,2,3,3,4,4,4},
    new List<int> { 1,2,3,3,4,4,4,5,6,7},
    new List<int> { 5,5,5,5,5}
};

var obtenerLaListaConMasDuplicados = listaNumeros.OrderByDescending(x => x.Count() - x.Distinct().Count()).FirstOrDefault();
Console.WriteLine("obtenerLaListaConMasDuplicados");
foreach (var num in obtenerLaListaConMasDuplicados)
{
    Console.WriteLine(num);
}

var personas = new List<Persona>() {
    new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
    new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
    new Persona { Nombre = "Alejandro", Edad = 45, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
    new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2021, 7, 8), Soltero = false },
    new Persona { Nombre = "Roberto", Edad = 60, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
    new Persona { Nombre = "Julio", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
    new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
    new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
    new Persona { Nombre = "Alejandro", Edad = 45, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
    new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2021, 7, 8), Soltero = false },
    new Persona { Nombre = "Roberto", Edad = 60, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
    new Persona { Nombre = "Julio", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
 };

var personasSinNombresRepeditos = personas.DistinctBy(x => x.Nombre);
Console.WriteLine("personasSinNombresRepeditos");
foreach (var persona in personasSinNombresRepeditos)
{
    Console.WriteLine(persona);
}

