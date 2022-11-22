using ANY;

var numeros = new[] { 1, 4, 10, 154, 999, 15 };

var primeros3Numeros = numeros.Take(3);

var tomarDel2Al6 = numeros.Take(2..6);  // numeros.Skip(2).Take(4)

var tomarTodosDespuesDel6 = numeros.Take(6..);

var tomarTodosAntesDel3 = numeros.Take(..3); //numeros.Take(3)

var tomarTpdpsAntesDel3PorElFinal = numeros.Take(..^3);

Console.WriteLine("primeros3Numeros: ");
foreach (var num in primeros3Numeros)
{
    Console.WriteLine(num);
}

var primeros300Numeros = numeros.Take(300); // NO EXCEPTION

Console.WriteLine("primeros300Numeros: ");
foreach (var num in primeros300Numeros)
{
    Console.WriteLine(num);
}

var ultimos5Numeros = numeros.TakeLast(5);
Console.WriteLine("ultimos5Numeros: ");
foreach (var num in ultimos5Numeros)
{
    Console.WriteLine(num);
}

var menoresQue20 = numeros.TakeWhile(n => n < 20);
Console.WriteLine("menoresQue20: ");
foreach (var num in menoresQue20)
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

var las3PersonasMasJovenes =  personas.OrderBy(x => x.Edad).Take(3);
Console.WriteLine("las3PersonasMasJovenes: ");
foreach (var persona in las3PersonasMasJovenes)
{
    Console.WriteLine(persona);
}
