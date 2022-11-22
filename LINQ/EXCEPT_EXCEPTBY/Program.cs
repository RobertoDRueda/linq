using ANY;


//EXCEPT todo lo que esta en la primera coleccion que no se encuentre en la segunda coleccion

int[] A = { 1, 2, 3 };
int[] B = { 1, 15 };

var numerosEnAQueNoEstanEnB = A.Except(B);

Console.WriteLine("numerosEnAQueNoEstanEnB");
foreach (int i in numerosEnAQueNoEstanEnB)
{
    Console.WriteLine(i);
}

/*
numerosEnAQueNoEstanEnB
2
3
*/

var personasA = new List<Persona>() {
    new Persona { Nombre = "Eduardo", EmpresaId = 1 },
    new Persona { Nombre = "Nidia",  EmpresaId = 1 },
    new Persona { Nombre = "Alejandro",  EmpresaId = 3 },
 };


var personasB = new List<Persona>() {
    new Persona { Nombre = "Fernando", EmpresaId = 25 },
    new Persona { Nombre = "Eduardo",  EmpresaId = 1 },
 };

var personasEnAQueNoEstanEnB = personasA.ExceptBy(personasB.Select(p => p.Nombre), x => x.Nombre);
Console.WriteLine("personasEnAQueNoEstanEnB:");
foreach (var persona in personasEnAQueNoEstanEnB)
{
    Console.WriteLine(persona);
}

/*
personasEnAQueNoEstanEnB:
Nombre: Nidia, Edad: 0, Soltero: False, FechaIngresoALaEmpresa: 1/1/0001 12:00:00 AM
Nombre: Alejandro, Edad: 0, Soltero: False, FechaIngresoALaEmpresa: 1/1/0001 12:00:00 AM
*/