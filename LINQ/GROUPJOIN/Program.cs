using ANY;
using GROUPBY;

var personas = new List<Persona>() {
    new Persona { Nombre = "Eduardo", EmpresaId = 1, },
    new Persona { Nombre = "Nidia", EmpresaId = 1 },
    new Persona { Nombre = "Alejandro",  EmpresaId = 2 },
    new Persona { Nombre = "Valentina",  EmpresaId = 2 },
    new Persona { Nombre = "Roberto", EmpresaId = 1 },
    new Persona { Nombre = "Julio", },
    new Persona { Nombre = "Eugenia",  EmpresaId = 3 },
    new Persona { Nombre = "Esmerlin",  EmpresaId = 3},
 };

var empresas = new List<Empresa>()
{
    new Empresa {Id = 1, Nombre = "Empresa 1"},
    new Empresa {Id = 2, Nombre = "Empresa 2"},
    new Empresa {Id = 3, Nombre = "Empresa 3"},
    new Empresa {Id = 4, Nombre = "Empresa 4"},
};


var empresasYSusEmpleados = empresas.GroupJoin(personas, e => e.Id, p => p.EmpresaId, (empresa, personas) => new { Empresa = empresa, Personas = personas });

foreach (var item in empresasYSusEmpleados)
{
    Console.WriteLine($"Las siguientes personas traban en {item.Empresa.Nombre}");
    foreach(var persona in item.Personas)
    {
        Console.WriteLine($"- {persona.Nombre}");
    }
}

/*
Las siguientes personas traban en Empresa 1
- Eduardo
- Nidia
- Roberto
Las siguientes personas traban en Empresa 2
- Alejandro
- Valentina
Las siguientes personas traban en Empresa 3
- Eugenia
- Esmerlin
Las siguientes personas traban en Empresa 4
*/

//Sintaxis de queries
var empresasYSusEmpleados2 = from empresa in empresas
                             join persona in personas on empresa.Id equals persona.EmpresaId into personasDeLaEmpresa
                             select new { Empresa = empresa, Personas = personasDeLaEmpresa };

foreach (var item in empresasYSusEmpleados2)
{
    Console.WriteLine($"Las siguientes personas traban en {item.Empresa.Nombre}");
    foreach (var persona in item.Personas)
    {
        Console.WriteLine($"- {persona.Nombre}");
    }
}

/*
Las siguientes personas traban en Empresa 1
- Eduardo
- Nidia
- Roberto
Las siguientes personas traban en Empresa 2
- Alejandro
- Valentina
Las siguientes personas traban en Empresa 3
- Eugenia
- Esmerlin
Las siguientes personas traban en Empresa 4
*/

var empleadosYSusEmpresas = personas.GroupJoin(
    empresas,
    p => p.EmpresaId,
    e => e.Id,
    (persona, empresa) =>
    {
        var formatPersonaEmpresa = string.Join(", ", empresa.Select(empresa => empresa.Nombre));
        return $"{persona.Nombre} trabaja en {formatPersonaEmpresa}";
    });
        
foreach(var item in empleadosYSusEmpresas)
{
    Console.WriteLine(item);
}

/*
Eduardo trabaja en Empresa 1
Nidia trabaja en Empresa 1
Alejandro trabaja en Empresa 2
Valentina trabaja en Empresa 2
Roberto trabaja en Empresa 1
Julio trabaja en
Eugenia trabaja en Empresa 3
Esmerlin trabaja en Empresa 3
*/

var empresasYSusEmpleados3 = personas.GroupJoin(
    empresas,
    p => p.EmpresaId,
    e => e.Id,    
    (personas,empresa) => new
    {
        Personas = personas,
        Empresa = empresa.DefaultIfEmpty(),
    }).SelectMany(PersonasempresaPair => PersonasempresaPair.Empresa,
    (PersonasempresaPair, singleEmpresa) =>
    $"{PersonasempresaPair.Personas.Nombre} trabaja en {singleEmpresa?.Nombre}");

foreach (var item in empresasYSusEmpleados3)
{
    Console.WriteLine(item);
}

/*
Eduardo trabaja en Empresa 1
Nidia trabaja en Empresa 1
Alejandro trabaja en Empresa 2
Valentina trabaja en Empresa 2
Roberto trabaja en Empresa 1
Julio trabaja en
Eugenia trabaja en Empresa 3
Esmerlin trabaja en Empresa 3
*/