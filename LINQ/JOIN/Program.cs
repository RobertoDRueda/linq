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
};

var personasYEmpresas = personas.Join(
                                        empresas,
                                        p => p.EmpresaId,
                                        e => e.Id,
                                        (persona, empresa) => new
                                        {
                                            Persona = persona,
                                            Empresa = empresa
                                        }
                                      );

foreach (var item in personasYEmpresas)
{
    Console.WriteLine($"{item.Persona.Nombre} trabaja en {item.Empresa.Nombre}.");
}

/*
Eduardo trabaja en Empresa 1.
Nidia trabaja en Empresa 1.
Alejandro trabaja en Empresa 2.
Valentina trabaja en Empresa 2.
Roberto trabaja en Empresa 1.
Eugenia trabaja en Empresa 3.
Esmerlin trabaja en Empresa 3.
*/


//Sintaxis de queries
var personasYEmpresas2 = from persona in personas
                         join empresa in empresas on persona.EmpresaId equals empresa.Id
                         select new
                         {
                             Persona = persona,
                             Empresa = empresa
                         };

foreach (var item in personasYEmpresas2)
{
    Console.WriteLine($"{item.Persona.Nombre} trabaja en {item.Empresa.Nombre}.");
}

/*
Eduardo trabaja en Empresa 1.
Nidia trabaja en Empresa 1.
Alejandro trabaja en Empresa 2.
Valentina trabaja en Empresa 2.
Roberto trabaja en Empresa 1.
Eugenia trabaja en Empresa 3.
Esmerlin trabaja en Empresa 3.
*/




var items = new[]
            {
              new Item(1, "Pastas"),
              new Item(2, "Mermeladas"),
              new Item(3, "Gaseosas")
            };

var clientes = new[]
{
              new Cliente(1, "Cristina Montenegro"),
              new Cliente(2, "Julio Aguirre"),
              new Cliente(3, "David Caceres")
            };

var ordenes = new[]
{
                new Orden(1, 2, 2),
                new Orden(2, 3, 1),
                new Orden(3, 1, 4)
            };

var ordenClientes = ordenes.Join(
                clientes,
                orden => orden.ClienteId,
                cliente => cliente.Id,
                (orden, cliente) => new { orden, cliente });

var ordenClienteItems = ordenClientes.Join(
    items,
    ordenCliente => ordenCliente.orden.ItemId,
    item => item.Id,
    (ordenCliente, item) => new
    {
        Orden = ordenCliente.orden,
        Cliente = ordenCliente.cliente,
        Item = item
    });

var detalleOrdenes = ordenClienteItems.Select(
    ordenClienteItem =>
        $"Cliente: {ordenClienteItem.Cliente.Nombre}," +
        $" Item: {ordenClienteItem.Item.Nombre}," +
        $" Cantidad: {ordenClienteItem.Orden.Cantidad}");

foreach(var item in detalleOrdenes)
{
    Console.WriteLine(item);
}

/*
Cliente: Cristina Montenegro, Item: Mermeladas, Cantidad: 2
Cliente: Julio Aguirre, Item: Gaseosas, Cantidad: 1
Cliente: David Caceres, Item: Pastas, Cantidad: 4
*/

//-----------------------------------------------------
public class Cliente
{
    public int Id { get; }
    public string Nombre { get; }

    public Cliente(int id, string nombre)
    {
        Id = id;
        Nombre = nombre;
    }

    public override string ToString()
    {
        return $"Id: {Id}, Nombre: {Nombre}";
    }
}

public class Orden
{
    public int ClienteId { get; }
    public int ItemId { get; }
    public int Cantidad { get; }

    public Orden(int clienteId, int itemId, int cantidad)
    {
        ClienteId = clienteId;
        ItemId = itemId;
        Cantidad = cantidad;
    }

    public override string ToString()
    {
        return $"ClienteId: {ClienteId}, ItemId: {ItemId}, Cantidad: {Cantidad}";
    }
}

public class Item
{
    public int Id { get; }
    public string Nombre { get; }

    public Item(int id, string nombre)
    {
        Id = id;
        Nombre = nombre;
    }

    public override string ToString()
    {
        return $"Id: {Id}, Nombre: {Nombre}";
    }
}