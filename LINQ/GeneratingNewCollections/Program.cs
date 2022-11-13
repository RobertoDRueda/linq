

/* Empty collection of ints */

var emptyInts = Enumerable.Empty<int>();
var defaultIfEmpty = emptyInts.DefaultIfEmpty(99);

Console.WriteLine("defaultIfEmpty:");
foreach (var n in defaultIfEmpty)
{
    Console.WriteLine(n);
}

/*
defaultIfEmpty:
99 
 */


var diesCopiasDe100 = Enumerable.Repeat(100, 10);

Console.WriteLine("diesCopiasDe100");
foreach (var copia in diesCopiasDe100)
{
    Console.WriteLine(copia);
}

/*
diesCopiasDe100
100
100
100
100
100
100
100
100
100
100
 */

var foxes = Enumerable.Repeat("fox", 3).Select( (word, index) => $"{index + 1}. {word}");
Console.WriteLine("foxes:");
foreach (var fox in foxes)
{
    Console.WriteLine(fox);
}
/*
foxes:
1. fox
2. fox
3. fox
 */

var diesATreinta = Enumerable.Range(10, 21);
Console.WriteLine("diesATreinta:");
foreach (var num in diesATreinta)
{
    Console.WriteLine(num);
}
/*
diesATreinta:
10
11
12
13
14
15
16
17
18
19
20
21
22
23
24
25
26
27
28
29
30 
*/

var potenciaDe2 = Enumerable.Range(0, 10).
                  Select(num => Math.Pow(2, num));

Console.WriteLine("potenciaDe2:");
foreach (var num1 in potenciaDe2)
{
    Console.WriteLine(num1);
}

/*
potenciaDe2:
1
2
4
8
16
32
64
128
256
512
 */

var letras = Enumerable.Range('A', 10);

Console.WriteLine("letras:");
foreach (var l in letras)
{
    Console.WriteLine(l);
}
/*
letras:
65
66
67
68
69
70
71
72
73
74 
 */

var letras2 = Enumerable.Range('A', 10).
              Select(num => (char)num);

Console.WriteLine("letras2:");
foreach (var l in letras2)
{
    Console.WriteLine(l);
}
/*
letras2:
A
B
C
D
E
F
G
H
I
J
 */


/*
 * Generar el siguiente patron
  "*\n**\n***\n****\n*****"
 */


var listaStr= Enumerable.Range(1, 5).Select(num => string.Join("", Enumerable.Repeat("*",num)));
var str = string.Join("\n", listaStr);
Console.WriteLine(str);
/*
*
**
***
****
*****
 */