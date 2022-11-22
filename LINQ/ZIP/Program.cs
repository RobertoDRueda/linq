
int[] A = { 1, 2, 3 };
int[] B = { 4, 5, 6 };

var combinados = A.Zip(B);

foreach (var combinado in combinados)
{
    Console.WriteLine($"({combinado.First},{combinado.Second})");
}

/*
(1,4)
(2,5)
(3,6)
*/

var multiplicarCombinados = A.Zip(B, (a,b) => a * b);
foreach (var combinado in multiplicarCombinados)
{
    Console.WriteLine(combinado);
}

/*
4
10
18
*/

var numeros = new[] { 1, 2, 3, 4, 5 };
var palabras = new[] { "perro", "gato", "loro", "mono", "rata" };

var numerosZippedConPalabras = numeros.Zip(
                               palabras,
                               (numero, palabra) => $"{numero}, {palabra}");

foreach (var item in numerosZippedConPalabras)
{
    Console.WriteLine(item);
}

/*
1, perro
2, gato
3, loro
4, mono
5, rata
*/

var numerosPalabrasDictionary = numeros.Zip(palabras).ToDictionary( x => x.First, x => x.Second);
foreach (var item in numerosPalabrasDictionary)
{
    Console.WriteLine($"Key: {item.Key} - Value: {item.Value}");
}

/*
Key: 1 - Value: perro
Key: 2 - Value: gato
Key: 3 - Value: loro
Key: 4 - Value: mono
Key: 5 - Value: rata
*/

var masNumeros = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var masNumerosZippedConPalabras = masNumeros.Zip(
                               palabras,
                               (numero, palabra) => $"{numero}, {palabra}");
foreach (var item in masNumerosZippedConPalabras)
{
    Console.WriteLine(item);
}
/*
1, perro
2, gato
3, loro
4, mono
5, rata
*/

IEnumerable<int> years = new[] { 2020, 2021, 2022 };
IEnumerable<int> months = new[] { 3, 5, 7 };
IEnumerable<int> days = new[] { 23, 25, 27 };

var fechas = years.Zip( months,
                       (year, month) => new { year, month }
                     ).Zip( days,
                            (yearMonth, day) => new DateTime(yearMonth.year, yearMonth.month, day))
                     .OrderBy(date => date);

foreach (var fecha in fechas)
{
    Console.WriteLine(fecha);
}

/*
3/23/2020 12:00:00 AM
5/25/2021 12:00:00 AM
7/27/2022 12:00:00 AM
*/


var listarPalabras = Enumerable
                     .Range('A', palabras.Count())
                     .Select(letra => (char)letra)
                     .Zip(palabras, (letra, palabra) => $"{letra}) {palabra}");

foreach (var item in listarPalabras)
{
    Console.WriteLine(item);
}

/*
A) perro
B) gato
C) loro
D) mono
E) rata
*/