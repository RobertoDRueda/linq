
// Concat se usa para concatenar dos secuencias en una secuencia.
// los argumentos no pueden ser nulos

char[] sequence1 = { 'p', 'q', 'r', 's', 'y', 'z' };
char[] sequence2 = { 'p', 'm', 'o', 'e', 'c', 'z' };


Console.WriteLine("Sequence 1 is: ");

foreach (var s1 in sequence1)
{
    Console.WriteLine(s1);
}

Console.WriteLine("Sequence 2 is: ");

foreach (var s2 in sequence2)
{
    Console.WriteLine(s2);
}

var result = sequence1.Concat(sequence2);

Console.WriteLine("New Sequence:");
foreach (var val in result)
{
    Console.WriteLine(val);
}


List<int> numbers1 = new List<int> { 1, 2, 3, 4 };
List<int> numbers2 = null;

try
{
    var resultNum = numbers1.Concat(numbers2);
    foreach (var item in resultNum)
    {
        Console.WriteLine(item);
    }
}
catch (Exception e) 
{ 
    Console.WriteLine($"El valor del segundo argumento no puede ser nulo: {e} "); 
}


try
{
    var resultNum2 = numbers2.Concat(numbers1);
    foreach (var item in resultNum2)
    {
        Console.WriteLine(item);
    }
}
catch (Exception e)
{
    Console.WriteLine($"El valor del primer argumento no puede ser nulo: {e} ");
}
