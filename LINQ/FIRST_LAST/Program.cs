using ANY;

//FIRST and LAST

var numbers = new[] { 3, 6, 2, 7, 9, 12, 8 };

var primerNumero = numbers.First();
Console.WriteLine($"primerNumero: {primerNumero}");
var ultimoNumero = numbers.Last();
Console.WriteLine($"ultimoNumero: {ultimoNumero}");

// Tambien podemos usar First con una query
var primerNumeroPar = numbers.First(n => n % 2 == 0);
Console.WriteLine($"primerNumeroPar: {primerNumeroPar}");
var ultimoNumeroPar = numbers.Last(n => n % 2 == 0);
Console.WriteLine($"ultimoNumeroPar: {ultimoNumeroPar}");

var personas = new List<Persona>() {
    new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
    new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
    new Persona { Nombre = "Alejandro", Edad = 45, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
    new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2021, 7, 8), Soltero = false },
    new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
 };

var primeraPersona = personas.First();
Console.WriteLine($"primeraPersona: {primeraPersona}");

//IMPORTANTE
//Si no hay ningún elemento ,se lanza una excepción: para evitar esto podemos usar FirstOrDefault o LastOrDefault
//retorna el valor por defecto de la coleccion

var listaVacia = new List<string>();
try
{
    var primerElemento = listaVacia.First();
}
catch (Exception ex)
{
    Console.WriteLine($"Ha ocurrido un error {ex.Message}");
}

var primerElemento2 = listaVacia.FirstOrDefault();
Console.WriteLine($"primerElemento2: {primerElemento2}"); //null

var numeros = new List<int>();
var primernumero = numeros.FirstOrDefault();
Console.WriteLine($"primernumero: {primernumero}"); //0

var primeraPersonaNoSoltera = personas.FirstOrDefault(p => !p.Soltero);
Console.WriteLine($"primeraPersonaNoSoltera: {primeraPersonaNoSoltera}");

var ultimaPersonaNoSoltera = personas.LastOrDefault(p => !p.Soltero);
Console.WriteLine($"ultimaPersonaNoSoltera: {ultimaPersonaNoSoltera}");