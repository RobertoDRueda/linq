

//INTERSECT busca todos los elementos comunes entre dos colecciones

using ANY;

int[] A = { 1, 2, 3 };
int[] B = { 1, 15 };

var numerosQueEstanEnAYEnB = A.Intersect(B);

Console.WriteLine("numerosQueEstanEnAYEnB");
foreach (int i in numerosQueEstanEnAYEnB)
{
    Console.WriteLine(i);
}

/*
numerosQueEstanEnAYEnB
1
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

var personasQueEstanEnPersonasAYPersonasB = personasA.IntersectBy(personasB.Select(p => p.Nombre), x => x.Nombre);
Console.WriteLine("personasQueEstanEnPersonasAYPersonasB:");
foreach (var persona in personasQueEstanEnPersonasAYPersonasB)
{
    Console.WriteLine(persona);
}

/*
personasQueEstanEnPersonasAYPersonasB:
Nombre: Eduardo, Edad: 0, Soltero: False, FechaIngresoALaEmpresa: 1 / 1 / 0001 12:00:00 AM
*/