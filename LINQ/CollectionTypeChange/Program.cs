

using CollectionTypeChange;

int[] numerosA = { 1, 2, 3, 1, 1, 6 };

List<int> numerosAsList = numerosA.ToList();
int[] numerosAsArray = numerosAsList.ToArray();

HashSet<int> hashSet = numerosA.ToHashSet();

Console.WriteLine("hashSet");
foreach (int num in hashSet) //{ 1, 2, 3, 6 };
{
    Console.WriteLine(num);
}

var Pets = new[]
    {
        new Pet(1, "Hannibal", PetType.Fish, 1.1f),
        new Pet(2, "Anthony", PetType.Cat, 2f),
        new Pet(3, "Ed", PetType.Cat, 0.7f),
        new Pet(4, "Taiga", PetType.Dog, 35f),
        new Pet(5, "Rex", PetType.Dog, 40f),
        new Pet(6, "Lucky", PetType.Dog, 5.7f),
        new Pet(7, "Storm", PetType.Cat, 1f),
        new Pet(8, "Nyan", PetType.Cat, 2.2f)
    };

// ToDictionary
var petDictionary = Pets.ToDictionary(
    pet => pet.Id, // Must have a nunique key
    pet => pet.Name);

Console.WriteLine("---------------------");
Console.WriteLine("petDictionary");
foreach(var pet in petDictionary)
{
    Console.WriteLine($"key: {pet.Key}, Value: {pet.Value}");
}


// ToLookup
var petTypeToNamesLookup = Pets.ToLookup(
    pet => pet.PetType,
    pet=> pet.Name);

Console.WriteLine("---------------------");
Console.WriteLine("petTypeToNamesLookup");
foreach (var petType in petTypeToNamesLookup)
{
    Console.WriteLine($" ---- PetType: { petType.Key} ---");
    foreach (var pet in petType)
    Console.WriteLine($"Name: {pet}");
}

// Cast
var numeros = new List<int> { 1, 2, 3, 1, 1, 6 };

IEnumerable<long> longNumbers = numeros.Cast<long>();

// GetValues
IEnumerable<PetType> allPetsTypes = Enum.GetValues(typeof(PetType)).Cast<PetType>();

foreach (var petType in allPetsTypes)  //Cat, Dog, Fish
{
    Console.WriteLine(petType);
}


IEnumerable<object> objects = new List<object>() { "1", 3, "abc", new DateTime(2020, 1, 2), true, "10" };

// Obtener una lista de numeros

var enteros = objects.OfType<int>()
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

Console.WriteLine("---------------------");
Console.WriteLine("Lista de numeros");
foreach (var n in enteros)
{
    Console.WriteLine(n);
}