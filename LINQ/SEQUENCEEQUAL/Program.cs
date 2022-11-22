using CONTAINS;

string[] A = { "felipe", "fernando" };
string[] B = { "felipe", "fernando" };
string[] C = { "FEliPE", "fernandO" }; 
string[] D = { "fernando", "felipe" };

var AB = A.SequenceEqual(B);
Console.WriteLine($"Las secuencias A y B son iguales {AB}");
//Las secuencias A y B son iguales True

var AC = A.SequenceEqual(C);
Console.WriteLine($"Las secuencias A y C son iguales {AC}");
//Las secuencias A y C son iguales False

var AD = A.SequenceEqual(D);
Console.WriteLine($"Las secuencias A y D son iguales {AD}");
//Las secuencias A y D son iguales False

var ACSinImportarMayusculas = A.SequenceEqual(C,StringComparer.OrdinalIgnoreCase);
Console.WriteLine($"Las secuencias A y C son iguales {ACSinImportarMayusculas}");
//Las secuencias A y C son iguales True

var puntosA = new List<Punto>() {
    new Punto { X = 10, Y = 20 },
    new Punto { X = 11, Y = 21 },
 };

var puntosB = new List<Punto>() {
    new Punto { X = 10, Y = 20 },
    new Punto { X = 11, Y = 21 },
 };

var puntosC = new List<Punto>() {
    new Punto { X = 10, Y = 20 },
    new Punto { X = 11, Y = 22 },
 };

var puntosAB = puntosA.SequenceEqual(puntosB, new PuntoComparer());
Console.WriteLine($"Las listas puntos A y B son iguales {puntosAB}");
//Las listas puntos A y B son iguales True

var puntosAC = puntosA.SequenceEqual(puntosC, new PuntoComparer());
Console.WriteLine($"Las listas puntos A y C son iguales {puntosAC}");
//Las listas puntos A y C son iguales False