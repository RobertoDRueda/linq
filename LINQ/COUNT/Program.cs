//Count returns the number of element that meet the specific criteria
//System.Linq.Enumerable.Count     => return int
//System.Linq.Enumerable.LongCount => return long, use to values greater than int.MaxvValue

using ANY;

var numbers = new[] { 3, 6, 2, 7, 9, 12, 8 };

var ContarLosNumerosMayoresA10 = numbers.Count(num => num > 10);
Console.WriteLine($"ContarLosNumerosMayoresA10: {ContarLosNumerosMayoresA10}");  // 1

var HayMasNumerosParesQueImpares = numbers.Count(number => number % 2 == 0) >
                                   numbers.Count(number => number % 2 != 0);

Console.WriteLine($"HayMasNumerosParesQueImpares: {HayMasNumerosParesQueImpares}");

var personas = new List<Persona>() {
    new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
    new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
    new Persona { Nombre = "Alejandro", Edad = 45, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
    new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2021, 7, 8), Soltero = false },
    new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
 };

Console.WriteLine($"La candidad de personas es: {personas.Count()}"); // 5
Console.WriteLine($"La candidad de personas solteres es: {personas.Count(p => p.Soltero)}"); // 2
Console.WriteLine($"La candidad de personas solteres menores de 30 es: {personas.Count(p => p.Soltero && p.Edad < 30)}"); // 1