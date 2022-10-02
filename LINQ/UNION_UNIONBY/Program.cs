using ANY;

int[] numerosA = { 1, 2, 3, 1, 1, 6 };
int[] numerosB = { 1, 2, 15 };

var unionNumerosAyB = numerosA.Union(numerosB); // 1, 2, 3, 6, 15

Console.WriteLine("unionNumerosAyB: ");
foreach (var num in unionNumerosAyB)
{
    Console.WriteLine(num);
}

int[] numerosA1 = { 1, 2, 3, 1, 1, 6 };
int[] numerosB1 = null;
int[] numerosC1 = null;

try
{
    var unionNumerosA1yB1 = numerosA1.Union(numerosB1); 
    Console.WriteLine("unionNumerosA1yB1: ");
    foreach (var num in unionNumerosA1yB1)
    {
        Console.WriteLine(num);
    }
}
catch (Exception ex)
{
    Console.WriteLine("Los parametros A1 y A2 No pueden ser nulos");
}

try
{
    var unionNumerosC1yA1 = numerosC1.Union(numerosA1); 
    Console.WriteLine("unionNumerosC1yA1: ");
    foreach (var num in unionNumerosC1yA1)
    {
        Console.WriteLine(num);
    }
}
catch (Exception ex)
{
    Console.WriteLine("Los parametros C1 y A1 No pueden ser nulos");
}

var personasA= new List<Persona>() {
    new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
    new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
    new Persona { Nombre = "Alejandro", Edad = 45, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
    new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2021, 7, 8), Soltero = false },
    new Persona { Nombre = "Roberto", Edad = 60, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
    new Persona { Nombre = "Julio", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
 };


var personasB = new List<Persona>() {
    new Persona { Nombre = "Enrique", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
    new Persona { Nombre = "Adrian", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
    new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2021, 7, 8), Soltero = false },
    new Persona { Nombre = "Roberto", Edad = 60, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
    new Persona { Nombre = "Julio", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
 };

var personasAyB_UnidasPorNombre = personasA.UnionBy(personasB, p => p.Nombre);

Console.WriteLine("personasAyB_UnidasPorNombre: ");
foreach (var persona in personasAyB_UnidasPorNombre)
{
    Console.WriteLine(persona);
}
