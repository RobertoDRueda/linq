
using ANY;

var numeros = Enumerable.Range(1, 20);

var resultado = numeros.Chunk(4);

var index = 1;
foreach (var chunk in resultado)
{
    Console.WriteLine($"Grupo {index++} de {resultado.Count()}");
    foreach (var numero in chunk)
        Console.WriteLine($"\t{numero}");
}

/*
Grupo 1 de 5
        1
        2
        3
        4
Grupo 2 de 5
        5
        6
        7
        8
Grupo 3 de 5
        9
        10
        11
        12
Grupo 4 de 5
        13
        14
        15
        16
Grupo 5 de 5
        17
        18
        19
        20
*/


var personas = new List<Persona>() {
    new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
    new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
    new Persona { Nombre = "Alejandro", Edad = 45, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
    new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2021, 7, 8), Soltero = false },
    new Persona { Nombre = "Roberto", Edad = 60, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
    new Persona { Nombre = "Julio", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
    new Persona { Nombre = "Eugenia", Edad = 27, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = true },
    new Persona { Nombre = "Esmerlin", Edad = 45, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
 };

var chunked = personas.Chunk(3);
index = 1;
foreach (var chunk in chunked)
{
    Console.WriteLine($"Grupo {index++} de {chunked.Count()}");
    foreach (var persona in chunk)
        Console.WriteLine($"{persona}");
}

/*
Grupo 1 de 3
Nombre: Eduardo, Edad: 30, Soltero: True, FechaIngresoALaEmpresa: 1/2/2021 12:00:00 AM
Nombre: Nidia, Edad: 19, Soltero: True, FechaIngresoALaEmpresa: 11/22/2015 12:00:00 AM
Nombre: Alejandro, Edad: 45, Soltero: False, FechaIngresoALaEmpresa: 4/12/2020 12:00:00 AM
Grupo 2 de 3
Nombre: Valentina, Edad: 24, Soltero: False, FechaIngresoALaEmpresa: 7/8/2021 12:00:00 AM
Nombre: Roberto, Edad: 60, Soltero: False, FechaIngresoALaEmpresa: 11/21/2022 12:35:10 PM
Nombre: Julio, Edad: 61, Soltero: False, FechaIngresoALaEmpresa: 11/21/2022 12:35:10 PM
Grupo 3 de 3
Nombre: Eugenia, Edad: 27, Soltero: True, FechaIngresoALaEmpresa: 11/21/2022 12:35:10 PM
Nombre: Esmerlin, Edad: 45, Soltero: False, FechaIngresoALaEmpresa: 11/21/2022 12:35:10 PM
*/