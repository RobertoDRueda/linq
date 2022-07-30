
using ANY;

//ElementAt : Este método nos permite acceder al elemento en el índice dado.

var personas = new List<Persona>() {
    new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
    new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
    new Persona { Nombre = "Alejandro", Edad = 45, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
    new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2021, 7, 8), Soltero = false },
    new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
 };

var primeraPersona = personas.ElementAt(0);
Console.WriteLine(primeraPersona);

var segundaPersona = personas.ElementAt(1);
Console.WriteLine(segundaPersona);

//Si no hay ningún elemento bajo el índice, se lanza una excepción: para evitar esto podemos usar ElementAtOrDefault

var personaNULA = personas.ElementAtOrDefault(99);
Console.WriteLine($"personaNULA: {personaNULA}");

var numbers = new[] { 3, 6, 2, 7, 9, 12, 8 };
var numeroNoExiste = numbers.ElementAtOrDefault(99);
Console.WriteLine(numeroNoExiste); //0