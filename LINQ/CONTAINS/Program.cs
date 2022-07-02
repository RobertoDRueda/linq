
using ANY;
using CONTAINS;


//Contains checks if given element is present in the collection

var numeros = Enumerable.Range(1, 10);

var estaElNumero3 = numeros.Contains(3); //true
Console.WriteLine($"estaElNumero3: {estaElNumero3}");

var estaElNumero20 = numeros.Contains(20); //false
Console.WriteLine($"estaElNumero20: {estaElNumero20}");

var personas = new List<Persona>() {
    new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
    new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
    new Persona { Nombre = "Alejandro", Edad = 45, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
    new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2021, 7, 8), Soltero = false },
    new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
 };

bool estaElItemNidia = personas.Contains(
                                 new Persona
                                 {
                                     Nombre = "Nidia",
                                     Edad = 19,
                                     FechaIngresoALaEmpresa = new DateTime(2015, 11, 22),
                                     Soltero = true
                                 });

Console.WriteLine($"estaElItemNidia: {estaElItemNidia}"); //false

var nidia = personas[2];
bool estaElItemNidia2 = personas.Contains((Persona)nidia);
Console.WriteLine($"estaElItemNidia2: {estaElItemNidia2}"); //true



bool estaElItemNidiaUsandoCustomComparer = personas.Contains(
                                 new Persona
                                 {
                                     Nombre = "Nidia",
                                     Edad = 19,
                                     FechaIngresoALaEmpresa = new DateTime(2015, 11, 22),
                                     Soltero = true
                                 });
Console.WriteLine($"estaElItemNidiaUsandoCustomComparer: {estaElItemNidiaUsandoCustomComparer}");


/* Para poder comparar el contenido de un objeto hay que implementar IEqualityComparer */

var puntos = new List<Punto>() {
    new Punto { X = 10, Y = 20 },
    new Punto { X = 11, Y = 21 },
    new Punto { X = 12, Y = 22 },
    new Punto { X = 13, Y = 23 },
    new Punto { X = 14, Y = 24 },
 };

bool estaElItem1121UandoCustomComparer = puntos.Contains(
    new Punto { X = 11, Y = 21 },
    new PuntoComparer());

Console.WriteLine($"estaElItem1121UandoCustomComparer: {estaElItem1121UandoCustomComparer}"); //true

