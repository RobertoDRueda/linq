//OrderBy creates a copy of the collection,
//which is ordered by the given criteria

using ANY;

var personas = new List<Persona>() {
    new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
    new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
    new Persona { Nombre = "Alejandro", Edad = 45, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
    new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2021, 7, 8), Soltero = false },
    new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
    new Persona { Nombre = "Julio", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
 };

Console.WriteLine("-------PERSONAS ORDENADAS ASC------");
var personasOrdenadasPorEdad = personas.OrderBy(p => p.Edad);

foreach (var persona in personasOrdenadasPorEdad)
{
    Console.WriteLine(persona.ToString());
}

Console.WriteLine("-------PERSONAS ORDENADAS DESC------");
var personasOrdenadasDescPorEdad = personas.OrderByDescending(p => p.Edad);

foreach (var persona in personasOrdenadasDescPorEdad)
{
    Console.WriteLine(persona.ToString());
}

Console.WriteLine("-------PERSONAS ORDENADAS POR EDAD Y NOMBRE------");
var personasOrdenadasPorEdadYNombre = personas.OrderBy(p => p.Edad).ThenBy(p => p.Nombre);

foreach (var persona in personasOrdenadasPorEdadYNombre)
{
    Console.WriteLine(persona.ToString());
}


Console.WriteLine("-------PERSONAS ORDENADAS POR EDAD ASC Y NOMBRE DESC------");
var personasOrdenadasPorEdadAscYNombreDesc = personas.OrderBy(p => p.Edad).ThenByDescending(p => p.Nombre);

foreach (var persona in personasOrdenadasPorEdadAscYNombreDesc)
{
    Console.WriteLine(persona.ToString());
}

Console.WriteLine("---------NUMEROS-------------");

int[] numeros = { 1, 5, 12, 2, 3, 5, 4, 7, 6 };

var numerosOrdenados = numeros.OrderBy(n => n);
foreach (var numero in numerosOrdenados)
{
    Console.WriteLine(numero);
}

bool[] valores = { true, false, false, true, false, false, true };
var valoresOrdenados = valores.OrderBy(n => n); //{ false, false, false, false, true, true, true }

// Teniendo en cuenta lo anterior podemos ordenar primeros los pares y luego los impares de un listado de numeros.

Console.WriteLine("----------ORDENAR PARES Y LUEGO IMPARES--------");
var numerosParesEImpares = numeros.OrderBy(n => n % 2 != 0); // {12, 2, 4, 6, 1, 5, 3, 5, 7}
var numerosParesEImparesDesc = numeros.OrderBy(n => n % 2 != 0).ThenByDescending(n => n); // {12, 6, 4, 2, 7, 5, 5, 3, 1}

foreach (var numero in numerosParesEImparesDesc)
{
    Console.WriteLine(numero);
}