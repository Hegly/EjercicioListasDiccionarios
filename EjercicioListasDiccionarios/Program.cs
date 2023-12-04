// Crear una lista que contenga 10 productos
List<string> Productos = new()
{
    "*Laptop",
    "*Celulares",
    "*Televisores",
    "*Tarjetas de Memoria",
    "*Cámaras",
    "*Impresoras",
    "*Altavoces",
    "*Tablet",
    "*Proyectores",
    "*Reloj inteligente"
 };

// Usar propiedad Insert y en el índice 3 agregar un nuevo producto
Productos.Insert(3, "*Auriculares");

// Remover el último elemento de la lista
Productos.RemoveAt(Productos.Count - 1);

// Mostrar la lista en la consola
Console.WriteLine("Lista de Productos:");
Console.WriteLine();
foreach (var producto in Productos)
{
    Console.WriteLine(producto);
}



// Crear un diccionario con datos de departamentos
// En el diccionario debe agregar 2 departamentos
Dictionary<string, Dictionary<string, string>> diccionarioDepartamentos = new()
{
   {
     "DepartamentoPT", new Dictionary<string, string>
       {
         {"Nombre", "Productos Tecnológicos"},
         {"Cabecera", "Director de Tecnología"},
         {"Superficie", "500 m²"},
         {"Poblacion", "1000 personas"}
       }
    },
   {
     "DepartamentoV", new Dictionary<string, string>
       {
         {"Nombre", "Ventas"},
         {"Cabecera", "Director de Ventas"},
         {"Superficie", "300 m²"},
         {"Poblacion", "800 personas"}
       }
    }
 };

// Mostrar en la consola el diccionario con su respectiva llave y valor
Console.WriteLine("\nDiccionario de departamentos:");
Console.WriteLine();
foreach (var departamento in diccionarioDepartamentos)
{
    Console.WriteLine($"Llave: {departamento.Key}");
    foreach (var detalle in departamento.Value)
    {
        Console.WriteLine($"{detalle.Key}:{detalle.Value}");
    }
    Console.WriteLine();
}