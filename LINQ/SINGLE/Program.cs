
using ANY;

// SINGLE
// Devuelve el único elemento de una secuencia que cumple una condición específica,
// y lanza una excepción si existe más de uno de esos elementos.

var personas = new List<Persona>() {
    new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
    new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
    new Persona { Nombre = "Alejandro", Edad = 45, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
    new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2021, 7, 8), Soltero = false },
    new Persona { Nombre = "Roberto", Edad = 60, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
    new Persona { Nombre = "Julio", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
 };

var personaMayorDe60 = personas.Single(p => p.Edad > 60);
Console.WriteLine($"personaMayorDe60: {personaMayorDe60}");


try 
{
    var personaMayorDe100 = personas.Single(p => p.Edad > 100);
    Console.WriteLine($"personaMayorDe100: {personaMayorDe100}");
}
catch (Exception ex)
{
    Console.WriteLine($"Error no hay ningun elemento que cumpla la condicion { ex.Message}");
}

//SingleOrDefault
//podemos usar SingleOrDefault para evitar la excepción
//cuando no existe tal elemento en la colección
// y lanza una excepción si existe más de uno de esos elementos.

try
{
    var personaMayorDe100_2 = personas.SingleOrDefault(p => p.Edad > 100);
    Console.WriteLine($"personaMayorDe100_2: {personaMayorDe100_2}");  //return null
}
catch (Exception ex)
{
    Console.WriteLine($"Error no hay ningun elemento que cumpla la condicion { ex.Message}");
}


try
{
    var personaMayorDe5 = personas.Single(p => p.Edad > 5);
    Console.WriteLine($"personaMayorDe5: {personaMayorDe5}");
}
catch (Exception ex)
{
    Console.WriteLine($"Error hay mas de un elemento que cumple la condicion { ex.Message}");
}

try
{
    var personaMayorDe5_2 = personas.SingleOrDefault(p => p.Edad > 5);
    Console.WriteLine($"personaMayorDe5_2: {personaMayorDe5_2}");
}
catch (Exception ex)
{
    Console.WriteLine($"Error hay mas de un elemento que cumple la condicion { ex.Message}");
}