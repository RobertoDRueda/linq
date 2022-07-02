// ANY Determines whether any element of a sequence satisfies a condition.

using ANY;

var numbers = new[] { 3, 6, 2, 7, 9, 12, 8 };

bool IsAnyLargerThan10 = numbers.Any(num => num > 10);

Console.WriteLine($"IsAnyLargerThan10: {IsAnyLargerThan10}");  // true

//we can use Any without parameter to check if the collection is not empty:
var isNotEmpty = numbers.Any();
Console.WriteLine($"isNotEmpty: {isNotEmpty}");

//------------------------------------------------------------------

var personas = new List<Persona>() {
    new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
    new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
    new Persona { Nombre = "Alejandro", Edad = 45, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
    new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2021, 7, 8), Soltero = false },
    new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
 };

bool IsAnyMinor = personas.Any(p => p.Edad < 18);
bool IsAnyMajorThan20 = personas.Any(p => p.Edad > 20); 

Console.WriteLine($"IsAnyMinor: {IsAnyMinor}"); // false
Console.WriteLine($"IsAnyLargerThan10: {IsAnyMajorThan20}"); // true

