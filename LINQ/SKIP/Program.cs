using ANY;

var numeros = new[] { 1, 4, 10, 154, 999, 15 };
var skip3Numeros = numeros.Skip(3); // 1, 4, 10
var skip100Numeros = numeros.Skip(100); //The collection is empty

var skip2Ultimos = numeros.SkipLast(2); // 1, 4, 10, 154

Console.WriteLine("skip2Ultimos");
foreach (var num in skip2Ultimos)
{
    Console.WriteLine(num);
}

/*
skip2Ultimos
1
4
10
154
*/

Console.WriteLine("skip2UltimosConTake");
var skip2UltimosConTake = numeros.Take(numeros.Count() - 2); // 1, 4, 10, 154
foreach (var num in skip2UltimosConTake)
{
    Console.WriteLine(num);
}

/*
skip2UltimosConTake
1
4
10
154 
*/

var skipWhileSmallerThan20 = numeros.SkipWhile(num => num < 20); // 154, 999, 15

var personas = new List<Persona>() {
    new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
    new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
    new Persona { Nombre = "Alejandro", Edad = 45, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
    new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2021, 7, 8), Soltero = false },
    new Persona { Nombre = "Roberto", Edad = 60, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
    new Persona { Nombre = "Julio", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
 };

var secondHlafOfPersonas = personas.Skip(personas.Count() / 2);
foreach (var persona in secondHlafOfPersonas)
{
    Console.WriteLine(persona);
}

/*
Nombre: Valentina, Edad: 24, Soltero: False, FechaIngresoALaEmpresa: 7/8/2021 12:00:00 AM
Nombre: Roberto, Edad: 60, Soltero: False, FechaIngresoALaEmpresa: 11/21/2022 3:59:21 PM
Nombre: Julio, Edad: 61, Soltero: False, FechaIngresoALaEmpresa: 11/21/2022 3:59:21 PM
*/


//function Pagination

var numbers = Enumerable.Range(1, 100);

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Pagina {i}");
    var paginado = numbers.Paginar(i, 10);
    foreach(var numero in paginado)
    {
        Console.WriteLine(numero);
    }
}

public static class IEnumerableExtensions
{
    public static IEnumerable<T> Paginar<T> (this IEnumerable<T> coleccion, int pagina, int registros)
    {
        return coleccion.Skip((pagina - 1) * registros).Take(registros);
    }
}

/*
Pagina 1
1
2
3
4
5
6
7
8
9
10
Pagina 2
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
Pagina 3
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
Pagina 4
31
32
33
34
35
36
37
38
39
40
Pagina 5
41
42
43
44
45
46
47
48
49
50
Pagina 6
51
52
53
54
55
56
57
58
59
60
Pagina 7
61
62
63
64
65
66
67
68
69
70
Pagina 8
71
72
73
74
75
76
77
78
79
80
Pagina 9
81
82
83
84
85
86
87
88
89
90
Pagina 10
91
92
93
94
95
96
97
98
99
100 
*/