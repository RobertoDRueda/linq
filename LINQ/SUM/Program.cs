using ANY;

var numbers = new[] { 3, 6, 2, 7, 9, 12, 8 };

var sumaNumbers = numbers.Sum();
Console.WriteLine($"sumaNumbers: {sumaNumbers}");

//------------------------------------------------------------------

var personas = new List<Persona>() {
    new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
    new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
    new Persona { Nombre = "Alejandro", Edad = 45, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
    new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2021, 7, 8), Soltero = false },
    new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
 };

var sumaDeEdades = personas.Sum(p => p.Edad);
Console.WriteLine($"sumaDeEdades: {sumaDeEdades}");


var emptyNumbers = new int[0];
var sum = emptyNumbers.Sum();
Console.WriteLine($"La suma de una collection vacia es: {sum}");// 0