using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaInventarioSimple;

class Producto
{
    public string Nombre { get; set; }
    public int Cantidad { get; set; }
    public double Precio { get; set; }
}

class Program
{
    static List<Producto> inventario = new List<Producto>();

    static void Main(string[] args)
    {
        bool salir = false;

        while (!salir)
        {
            MostrarMenu();
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    AgregarProducto();
                    break;
                case "2":
                    ListarProductos();
                    break;
                case "3":
                    BuscarProducto();
                    break;
                case "4":
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                    break;
            }

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }

    static void MostrarMenu()
    {
        Console.Clear();
        Console.WriteLine("SISTEMA DE INVENTARIO");
        Console.WriteLine("1. Agregar producto.");
        Console.WriteLine("2. Listar productos.");
        Console.WriteLine("3. Buscar producto.");
        Console.WriteLine("4. Salir.");
        Console.Write("\nSeleccione una opción: ");
    }

    static void AgregarProducto()
    {
        Console.Clear();
        Console.WriteLine("AGREGAR NUEVO PRODUCTO");

        Producto nuevoProducto = new Producto();

        Console.Write("Nombre: ");
        nuevoProducto.Nombre = Console.ReadLine();

        Console.Write("Cantidad: ");
        if (!int.TryParse(Console.ReadLine(), out int cantidad))
        {
            Console.WriteLine("Error: La cantidad debe ser un número entero.");
            return;
        }
        nuevoProducto.Cantidad = cantidad;

        Console.Write("Precio: ");
        if (!double.TryParse(Console.ReadLine(), out double precio))
        {
            Console.WriteLine("Error: El precio debe ser un número válido.");
            return;
        }
        nuevoProducto.Precio = precio;

        inventario.Add(nuevoProducto);
        Console.WriteLine("\n¡Producto agregado exitosamente!");
    }

    static void ListarProductos()
    {
        Console.Clear();
        Console.WriteLine("LISTA DE PRODUCTOS EN INVENTARIO");

        if (!inventario.Any())
        {
            Console.WriteLine("No hay productos en el inventario.");
            return;
        }

        Console.WriteLine("{0,-10} {1,-10} {2,-10}", "Nombre", "Cantidad", "Precio");
        Console.WriteLine(new string('-', 30));

        foreach (var producto in inventario)
        {
            Console.WriteLine("{0,-10} {1,-10} {2,10:N0} ₲",
                producto.Nombre,
                producto.Cantidad,
                producto.Precio);
        }

        Console.WriteLine($"\nTotal de productos: {inventario.Count}");
    }

    static void BuscarProducto()
    {
        Console.Clear();
        Console.WriteLine("BUSCAR PRODUCTO");

        Console.Write("Ingrese el nombre del producto a buscar: ");
        string nombreBuscado = Console.ReadLine();

        var productosEncontrados = inventario
            .Where(p => p.Nombre.ToLower().Contains(nombreBuscado.ToLower()))
            .ToList();

        if (!productosEncontrados.Any())
        {
            Console.WriteLine($"\nNo se encontraron productos con '{nombreBuscado}'.");
            return;
        }

        Console.WriteLine("\nProductos encontrados:");
        Console.WriteLine("{0,-10} {1,-10} {2,-10}", "Nombre", "Cantidad", "Precio");
        Console.WriteLine(new string('-', 30));

        foreach (var producto in productosEncontrados)
        {
            Console.WriteLine("{0,-10} {1,-10} {2,10:N0} ₲",
                producto.Nombre,
                producto.Cantidad,
                producto.Precio);
        }
    }
}