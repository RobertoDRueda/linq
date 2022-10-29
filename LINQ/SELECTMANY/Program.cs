

using ANY;

var personas = new List<Persona>() {
    new Persona { Nombre = "Eduardo", Telefonos= { "123-456", "789-852"} },
    new Persona { Nombre = "Nidia", Telefonos= { "987-456", "789-689"}},
    new Persona { Nombre = "Alejandro", Telefonos= { "654-456", "789-878"} },
    new Persona { Nombre = "Valentina", Telefonos= { "187-456", "789-357"} },
    new Persona { Nombre = "Roberto", Telefonos= { "983-456"} },
 };

var telefonos = personas.SelectMany(a => a.Telefonos).ToList();

Console.WriteLine("telefonos");
foreach (var telefono in telefonos)
{
    Console.WriteLine(telefono);
}

/*
telefonos
123-456
789-852
987-456
789-689
654-456
789-878
187-456
789-357
983-456
 */

// producto cartesiano
int[] numeros = { 1, 2, 3 };

var personasYNumeros = personas.SelectMany(p => numeros, (persona, numero) => 
                       new
                            {
                                Persona = persona, 
                                Numero = numero 
                            });

foreach (var item in personasYNumeros)
{
    Console.WriteLine($"{item.Persona.Nombre} - {item.Numero}");
}
/*
Eduardo - 1
Eduardo - 2
Eduardo - 3
Nidia - 1
Nidia - 2
Nidia - 3
Alejandro - 1
Alejandro - 2
Alejandro - 3
Valentina - 1
Valentina - 2
Valentina - 3
Roberto - 1
Roberto - 2
Roberto - 3
*/


var personasYTelefonos = personas.SelectMany(p => p.Telefonos, (persona,telefono) => 
                        new
                        {
                            Persona = persona,
                            Telefono = telefono
                        }).ToList();

foreach (var item in personasYTelefonos)
{
    Console.WriteLine($"{item.Persona.Nombre} - {item.Telefono}");
}

/*
Eduardo - 123-456
Eduardo - 789-852
Nidia - 987-456
Nidia - 789-689
Alejandro - 654-456
Alejandro - 789-878
Valentina - 187-456
Valentina - 789-357
Roberto - 983-456
*/


/* ----------------------------------
Por ejemplo, para una entrada {1,2,5} el resultado debe ser:
{"1,1", "1,2", "1,5", "2,1", "2,2", "2,5", "5,1", "5,2", "5,5" }
-------------------------------------*/

HashSet<int> numbers = new HashSet<int> { 1, 2, 5};

var cartesian = numbers.SelectMany(n1 => numbers, (n1, n2) => $"{n1},{n2}");

