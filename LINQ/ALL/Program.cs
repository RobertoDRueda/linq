using ANY;


//All is used to check if all elements in the collection meet the specific criteria


var personas = new List<Persona>() {
    new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
    new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
    new Persona { Nombre = "Alejandro", Edad = 45, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
    new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2021, 7, 8), Soltero = false },
    new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
 };


var sonTodasLasPersonasMayoresDeEdad = personas.All(p => p.Edad >= 18);
Console.WriteLine($"sonTodasLasPersonasMayoresDeEdad: {sonTodasLasPersonasMayoresDeEdad}"); // true

var sonTodasLasPersonasSolteras = personas.All(p => p.Soltero);
Console.WriteLine($"sonTodasLasPersonasSolteras: {sonTodasLasPersonasSolteras}"); // false

/*--------------------------------------------------------*/

var numbers = new[] { 3, 6, 2, 7, 9, 12, 8 };

var sonTodosLosNumerosMayoresQueCero = numbers.All(n => n > 0);
Console.WriteLine($"sonTodosLosNumerosMayoresQueCero: {sonTodosLosNumerosMayoresQueCero}");  // true

var palabras = new[] { "Estoy", "Menta", "Casas", "Perro", "Gatos" };

var sonTodaslasPalabrasDeLaMismaLongitud = !palabras.Any() || palabras.All(p => p.Length == palabras[0].Length);
Console.WriteLine($"sonTodaslasPalabrasDeLaMismaLongitud: {sonTodaslasPalabrasDeLaMismaLongitud}"); // true

