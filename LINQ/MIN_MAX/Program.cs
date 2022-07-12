using ANY;

Console.WriteLine("---------NUMEROS-------------");

int[] numeros = { 1, 5, 12, 2, 3, 5, 4, 7, 6 };

var numerosMasChico = numeros.Min();
var numerosMasGrande = numeros.Max();

Console.WriteLine($"numerosMasChico: {numerosMasChico}");
Console.WriteLine($"numerosMasGrande: {numerosMasGrande}");

var personas = new List<Persona>() {
    new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
    new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
    new Persona { Nombre = "Alejandro", Edad = 45, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
    new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2021, 7, 8), Soltero = false },
    new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
    new Persona { Nombre = "Julio", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
 };

var elMasJoven = personas.Min(x => x.Edad);
var elMasViejo = personas.Max(x => x.Edad);

Console.WriteLine($"elMasJoven: {elMasJoven}"); // 19
Console.WriteLine($"elMasViejo: {elMasViejo}"); // 61

var minPersona = personas.Min(); // We need to use IComparable<Persona> for that
Console.WriteLine($"minPersona: {minPersona}");


// MaxBy MinBy  --- obtenemos el elemento (Persona) que contien dicho valor
var personaMasJoben = personas.MinBy(x => x.Edad);
Console.WriteLine($"personaMasJoben: {personaMasJoben}");

var personaMasVieja = personas.MaxBy(x => x.Edad);
Console.WriteLine($"personaMasVieja: {personaMasVieja}");

// Si la coleccion esta vacia, obtenemos un error al utilizar MIN o MAX