
var numeros = Enumerable.Range(1, 10);

var resultado = numeros.Aggregate( (a, b) => a + b); // 1+2+3+4....

Console.WriteLine($"El resultado es: {resultado}");
//El resultado es: 55


/* AGGREGATE con una semilla*/
var resultadoConValorInicial = numeros.Aggregate( 5 ,(a, b) => a + b); //semilla+1+2+3+4....

Console.WriteLine($"El resultado con la semilla es: {resultadoConValorInicial}");
//El resultado con la semilla es: 60

var numeros2 = new[] { 10, 5, 23, 124, 43 };
var sumaDeNumeros = numeros2.Aggregate( (sum, nextNumber) => sum + nextNumber);
Console.WriteLine($"La suma de numeros2 es {sumaDeNumeros}");
//La suma de numeros2 es 205

var sentencia = "Aplica una función de acumulador a una secuencia. El valor de inicialización especificado se utiliza como valor inicial del acumulador";
var laPalabraMasLarga = sentencia.Split(" ").
    Aggregate( (palabraMasLarga, siguientePalabra) =>
                siguientePalabra.Length > palabraMasLarga.Length 
                        ? siguientePalabra 
                        : palabraMasLarga);
Console.WriteLine($"La palabra mas larga es: {laPalabraMasLarga}");
//La palabra mas larga es: inicialización

var todasLasLongitudes = sentencia.Split(" ").
    Aggregate(
    Enumerable.Empty<int>(),
    (ListaLongitudes, siguientePalabra) => 
        ListaLongitudes.Append(siguientePalabra.Length));

foreach (var longitud in todasLasLongitudes)
{
    Console.WriteLine(longitud);
}
/*
6
3
7
2
10
1
3
10
2
5
2
14
12
2
7
4
5
7
3
10
*/

var letras = new[] { "a", "b", "c", "d", "e" };

var juntarLetras = letras.Aggregate( (letra, siguienteLetra) => $"{letra},{siguienteLetra}");
Console.WriteLine($"Todas las letras son: {juntarLetras}");
//Todas las letras son: a,b,c,d,e

var contarLetras = letras.Aggregate(0, (letra, siguienteLetra) => letra + 1);
Console.WriteLine($"La cantidad e letras son: {contarLetras}");
//La cantidad e letras son: 5

int numero = 10;
var factorial = Enumerable.Range(1, numero -1).
                Aggregate(
                numero,
                (factorialDeNumero, siguientenumero) =>
                factorialDeNumero * (numero - siguientenumero));
Console.WriteLine($"El factorial de {numero} es {factorial}");
//El factorial de 10 es 3628800