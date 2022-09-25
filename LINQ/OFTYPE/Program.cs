

using System.Linq;

var listado = new List<object>() { "Daniel", 1, 3, "Claudia", true};

var strings = listado.OfType<string>();
var integer = listado.OfType<int>();

Console.WriteLine("Strings:");
foreach (var item in strings)
    Console.WriteLine(item);
Console.WriteLine("Integer:");
foreach (var item in integer)
    Console.WriteLine(item);

var listadoAnimales = new List<Animal>()
{
    new Perro() { Name ="Firulais" },
    new Gato() { Name = "Felix"}
};

var perros = listadoAnimales.OfType<Perro>();
Console.WriteLine(perros.First());
var Gatos = listadoAnimales.OfType<Gato>();
Console.WriteLine(Gatos.First());
public abstract class Animal
{
    public abstract string? Name { get; set; }
}

public class Perro : Animal
{
    public override string? Name { get; set; }
}

public class Gato : Animal
{
    public override string? Name { get; set; }
}