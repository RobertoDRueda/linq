


using ANY;

int[] numeros = Enumerable.Range(1, 20).ToArray();

var numerosImpares = numeros.Where(x => x % 2 == 1).ToList();
var numerosPares = numeros.Where(x => x % 2 == 0).ToList();

Console.WriteLine("Numeros Impares");
foreach (var num in numerosImpares)
{
    Console.WriteLine(num);
}

Console.WriteLine("Numeros Pares");
foreach (var num in numerosPares)
{
    Console.WriteLine(num);
}

var numerosImparesMayoresQue10 = numeros.Where(x => x % 2 == 1 && x > 10).ToList();
Console.WriteLine("Numeros Impares mayores que 10");
foreach (var num in numerosImparesMayoresQue10)
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
 };

var personasHasta25Year = personas.Where(x => x.Edad <= 25 ).ToList();

Console.WriteLine("personasHasta25Year");
foreach (var p in personasHasta25Year)
{
    Console.WriteLine(p);
}

var solteros = personas.Where(p => p.Soltero).ToList();
Console.WriteLine("solteros");
foreach (var p in solteros)
{
    Console.WriteLine(p);
}

var personasConMenosDe3MesesEnLaEmpresa = personas.Where(x => x.FechaIngresoALaEmpresa >= DateTime.Now.AddMonths(-3)).ToList();
Console.WriteLine("personasConMenosDe3MesesEnLaEmpresa");
foreach (var p in personasConMenosDe3MesesEnLaEmpresa)
{
    Console.WriteLine(p);
}

var indexPorPersona = new[] { 2, 3, 4, 5 };
var personasPorIndexYMayoresQue20 = personas.Where( (persona, index) => 
                                                persona.Edad > 20 &&
                                                indexPorPersona.Contains(index));
Console.WriteLine("personasPorIndexYMayoresQue20");
foreach (var p in personasPorIndexYMayoresQue20)
{
    Console.WriteLine(p);
}