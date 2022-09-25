

using ANY;

var numeros = new[] { 1, 4, 10, 154, 999, 15 };
var skip3Numeros = numeros.Skip(3); // 1, 4, 10
var skip100Numeros = numeros.Skip(100); //The collection is empty

var skip2Ultimos = numeros.SkipLast(2); // 1, 4, 10, 154

Console.WriteLine("skip2Ultimos");
foreach (var num in skip2Ultimos)
{
    Console.WriteLine(num);
}

Console.WriteLine("skip2UltimosConTake");
var skip2UltimosConTake = numeros.Take(numeros.Count() - 2); // 1, 4, 10, 154
foreach (var num in skip2UltimosConTake)
{
    Console.WriteLine(num);
}

var skipWhileSmallerThan20 = numeros.SkipWhile(num => num < 20); // 154, 999, 15

var personas = new List<Persona>() {
    new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
    new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
    new Persona { Nombre = "Alejandro", Edad = 45, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
    new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2021, 7, 8), Soltero = false },
    new Persona { Nombre = "Roberto", Edad = 60, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
    new Persona { Nombre = "Julio", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
 };

var secondHlafOfPersonas = personas.Skip(personas.Count() / 2);
foreach (var persona in secondHlafOfPersonas)
{
    Console.WriteLine(persona);
}


//function Pagination

var numbers = Enumerable.Range(1, 100);

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"Pagina {i}");
    var paginado = numbers.Paginar(i, 10);
    foreach(var numero in paginado)
    {
        Console.WriteLine(numero);
    }
}

public static class IEnumerableExtensions
{
    public static IEnumerable<T> Paginar<T> (this IEnumerable<T> coleccion, int pagina, int registros)
    {
        return coleccion.Skip((pagina - 1) * registros).Take(registros);
    }
}