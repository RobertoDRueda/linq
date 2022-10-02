

using ANY;

int[] numeros = { 1, 2, 3, 4, 5, 6 };

var numerosConElNumero7 = numeros.Append(7); // 1, 2, 3, 4, 5, 6, 7

Console.WriteLine("numerosConElNumero7");
foreach (var num in numerosConElNumero7)
{
    Console.WriteLine(num);
}

var numerosConElNumero0 = numeros.Prepend(0); //  0, 1, 2, 3, 4, 5, 6 

Console.WriteLine("numerosConElNumero0");
foreach (var num in numerosConElNumero0)
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

var personasConAndrea = personas.Append(
                            new Persona { 
                                Nombre = "Andrea", 
                                Edad = 18, 
                                FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), 
                                Soltero = true 
                            });
Console.WriteLine("personasConAndrea");
foreach (var persona in personasConAndrea)
{
    Console.WriteLine(persona);
}

var levels = new List<string> { "Malo", "Intermedio", "Bueno"};
var newLevels = levels.Prepend("Terrible").Append("Excelente");

Console.WriteLine("newLevels");
foreach (var level in newLevels)
{
    Console.WriteLine(level);
}