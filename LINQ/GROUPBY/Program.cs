using ANY;
using GROUPBY;

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

var agrupameintoPorSolteria = personas.GroupBy(p => p.Soltero);

foreach (var grupoSolteria in agrupameintoPorSolteria)
{
    Console.WriteLine($"Grupo de las personas donde Soltero = {grupoSolteria.Key} (Total: {grupoSolteria.Count()})");
    foreach(var persona in grupoSolteria)
    {
        Console.WriteLine($"- {persona.Nombre}");
    }
}

/*
Grupo de las personas donde Soltero = True (Total: 3)
- Eduardo
- Nidia
- Eugenia
Grupo de las personas donde Soltero = False (Total: 5)
- Alejandro
- Valentina
- Roberto
- Julio
- Esmerlin
*/


var rangoEdad = 5;
var agrupamientoPorRangoEdad = personas.OrderBy(p => p.Edad).GroupBy(p => p.Edad / rangoEdad);
foreach (var grupoEdad in agrupamientoPorRangoEdad)
{
    Console.WriteLine($"Grupo de las personas en el range de edad {grupoEdad.Key * rangoEdad} - {grupoEdad.Key * rangoEdad + rangoEdad - 1}");
    foreach (var persona in grupoEdad)
    {
        Console.WriteLine($"- {persona.Nombre} edad: {persona.Edad}");
    }
}

/*
Grupo de las personas en el range de edad 15 - 19
- Nidia edad: 19
Grupo de las personas en el range de edad 20 - 24
- Valentina edad: 24
Grupo de las personas en el range de edad 25 - 29
- Eugenia edad: 27
Grupo de las personas en el range de edad 30 - 34
- Eduardo edad: 30
Grupo de las personas en el range de edad 45 - 49
- Alejandro edad: 45
- Esmerlin edad: 45
Grupo de las personas en el range de edad 60 - 64
- Roberto edad: 60
- Julio edad: 61
*/


//Implemente el método Obtener el carácter más frecuente de un string
var text = "Materiales de contrucciones";
var caracterMasFrecuente = text.ToLower()
                               .GroupBy(c => c)
                               .OrderByDescending(c => c.Count())
                               .First()
                               .Key;

Console.WriteLine($"El caracter mas frecutne del texto '{text}' es '{caracterMasFrecuente}'");
/*
El caracter mas frecutne del texto 'Materiales de contrucciones' es 'e'
*/


//Promediar la edad de los solteros y no solteros, indicando cual es mayor
var FindTheHeaviestSoltero = personas
                                     .GroupBy(p => p.Soltero)
                                     .OrderByDescending(g => g.Average( p => p.Edad))
                                     .First().Key;

Console.WriteLine($"FindTheHeaviestSoltero es Soltero = {FindTheHeaviestSoltero}");
//FindTheHeaviestSoltero es Soltero = False




/* Contar la cantidad de mascotas que existe en este string*/
var mascotas = "Perro,Gato,Pez,Perro,Perro,Pez,Gato,Gato,Perro,Hurón,Perro";
IEnumerable<string> cantidadMascotas = mascotas
                                               .Split(',')
                                               .GroupBy(word => word)
                                               .Select(group => $"{group.Key}:{group.Count()}");
Console.WriteLine("cantidadMascotas");
foreach (var mascota in cantidadMascotas)
{
    Console.WriteLine(mascota);
}

/*
cantidadMascotas
Perro:5
Gato:3
Pez:2
Hurón:1
*/