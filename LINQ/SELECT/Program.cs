using ANY;
using SELECT;

var personas = new List<Persona>() {
    new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
    new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
    new Persona { Nombre = "Alejandro", Edad = 45, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
    new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2021, 7, 8), Soltero = false },
    new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
 };


var nombres = personas.Select(p => p.Nombre).ToList();

Console.WriteLine("nombres");
foreach (var nombre in nombres)
{
    Console.WriteLine(nombre);
}

var nombresYEdades = personas.Select(p => new {Nombre = p.Nombre, Edad = p.Edad}).ToList();

Console.WriteLine("nombresYEdades");
foreach (var nombreYEdad in nombresYEdades)
{
    Console.WriteLine(nombreYEdad);
}

var nombresYEdadesDTO = personas.Select(p => new PersonaDTO { Nombre = p.Nombre, Edad = p.Edad }).ToList();

Console.WriteLine("nombresYEdadesDTO");
foreach (var nombreYEdadDTO in nombresYEdadesDTO)
{
    Console.WriteLine(nombreYEdadDTO);
}

var personasConIdice = personas.Select( (p, indice) => new { indice = indice+1, Nombre = p.Nombre }).ToList();
Console.WriteLine("personasConIdice");
foreach (var item in personasConIdice)
{
    Console.WriteLine($"{item.indice}) {item.Nombre}");
}

var numeros = Enumerable.Range(1, 5).ToList();
var numerosDuplicados = numeros.Select(n => n * 2).ToList();

Console.WriteLine("numerosDuplicados");
foreach (var num in numerosDuplicados)
{
    Console.WriteLine(num);
}

IEnumerable<object> objects = new List<object>() { "1", 3, "abc", new DateTime(2020, 1, 2), true, "10" };
// Obtener numeros

var soloNumeros = objects.OfType<int>()
                 .Concat(
                    objects.OfType<string>()
                    .Select(s =>
                    {
                        int numero;
                        return int.TryParse(s, out numero) ? numero : (int?)null;
                    })
                    .Where(n => n != null)
                    .Select(n => n.Value)
                 ).OrderBy(n => n);

Console.WriteLine("soloNumeros");
foreach (var num in soloNumeros)
{
    Console.WriteLine(num);
}


// Obtener personas validas de un string y asignarlas a la clase Persona

string strPersonas = "John Smith|12, 1983/08/21;Jane Doe|45, 1993/12/21;Francis Brown|error, invalid date here";

IEnumerable<Persona?> personasValidas = strPersonas.Split(';')
                                .Select(s =>
                                             {
                                                 try
                                                 {
                                                     var posiblePersona = s.Split(',');
                                                     var nombreYEdad = posiblePersona[0].Split('|');
                                                     var nombre = nombreYEdad[0];
                                                     var edad = int.Parse(nombreYEdad[1]);
                                                     var fechaIngreso = DateTime.Parse(posiblePersona[1]);
                                                     return new Persona { Nombre = nombre, Edad = edad, FechaIngresoALaEmpresa = fechaIngreso };
                                                 }
                                                 catch (Exception ex)
                                                 {
                                                     return (Persona) null;
                                                 }
                                             }
                                ).Where(p => p != null);


Console.WriteLine("personasValidas");
foreach (var personaValida in personasValidas)
{
    Console.WriteLine(personaValida);
}