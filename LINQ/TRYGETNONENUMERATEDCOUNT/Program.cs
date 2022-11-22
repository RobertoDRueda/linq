
using ANY;

var numeros = Enumerable.Range(1, 20);

var conteo = 0;

var pudoContarSinEnumerar = numeros.TryGetNonEnumeratedCount(out conteo);

if (pudoContarSinEnumerar)
    Console.WriteLine($"La cantidad de elementos en la coleccion numeros es: {conteo}");
else
    Console.WriteLine($"No se pudo contar sin enumerar");

//La cantidad de elementos en la coleccion numeros es: 20


var personasA = new List<Persona>()
{
    new Persona { Nombre = "Eduardo", EmpresaId = 1},
    new Persona { Nombre = "Nidia", EmpresaId = 1},
    new Persona { Nombre = "Esmerlin", EmpresaId = 3},
};


var personasCollection = new PersonasCollection();
personasCollection.AddRange(personasA);

var conteoPersonas = personasCollection.Count(); //Entra al GetEnumerator() y recorremos la coleccion

var conteoPersonas2 = 0;
var pudoContarPersonasSinEnumerar = personasCollection.TryGetNonEnumeratedCount(out conteoPersonas2);

Console.WriteLine($"pudoContarPersonasSinEnumerar: {pudoContarPersonasSinEnumerar}");
Console.WriteLine($"conteoPersonas2: {conteoPersonas2}");

/*
pudoContarPersonasSinEnumerar: True
conteoPersonas2: 3
*/

public class PersonasCollection : IEnumerable<Persona>, ICollection<Persona>
{
    private readonly List<Persona> _personas = new List<Persona>();

    public int Count => _personas.Count();

    public bool IsReadOnly => throw new NotImplementedException();

    public void Add(Persona persona) 
    { 
        _personas.Add(persona); 
    }

    public void AddRange(IEnumerable<Persona> personas)
    {
        _personas.AddRange(personas);
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Contains(Persona item)
    {
        throw new NotImplementedException();
    }

    public void CopyTo(Persona[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Persona> GetEnumerator()
    {
        return _personas.GetEnumerator();
    }

    public bool Remove(Persona item)
    {
        throw new NotImplementedException();
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return ((IEnumerable<Persona>)_personas).GetEnumerator();
    }

}