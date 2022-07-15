using ANY;

var numbers = new[] { 3, 6, 2, 7, 9, 12, 8 };

var averageNumbers = numbers.Average();
Console.WriteLine($"averageNumbers: {averageNumbers}");

//------------------------------------------------------------------

var personas = new List<Persona>() {
    new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
    new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
    new Persona { Nombre = "Alejandro", Edad = 45, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
    new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2021, 7, 8), Soltero = false },
    new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
 };

var averageEdad = personas.Average( p => p.Edad );
Console.WriteLine($"averageEdad: {averageEdad}");


//-------NO podemos usar Average en una Coleccion vacia----------------

var emptyNumbers = new int[0];
try
{
    var averageempty = emptyNumbers.Average();
    Console.WriteLine($"averageempty: {averageempty}");
}
catch (Exception ex)
{
    Console.WriteLine("Average - Coleccion vacia "+ex.ToString());
}

