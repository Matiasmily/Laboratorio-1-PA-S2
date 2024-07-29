// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<double> preciosProductos = new List<double>();
        int opcion = 0;
        bool continueOne = true;
        do
        {
            try
            {
                MostrarMenu();
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        IngresarProductos(preciosProductos);
                        break;
                    case 2:
                        CalcularTotal(preciosProductos);
                        break;
                    case 3:
                        Console.WriteLine("\nUsted está saliendo del programa...");
                        Console.WriteLine("Presione Enter para continuar");
                        Console.ReadKey();
                        continueOne = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Error: Por favor ingrese una opción numérica");
                Console.WriteLine("Presione Enter para continuar");
                Console.ReadKey();
            }
        } while (continueOne);
    }

    static void MostrarMenu()
    {
        Console.Clear();
        Console.WriteLine("---- TIENDA EN LÍNEA ---");
        Console.WriteLine("1. Ingresar Productos");
        Console.WriteLine("2. Total de la compra");
        Console.WriteLine("3. Salir");
        Console.Write("Ingrese una opción: ");
    }

    static void IngresarProductos(List<double> preciosProductos)
    {
        Console.Clear();
        Console.Write("Ingrese el nombre del producto: ");
        string nombre = Console.ReadLine();
        Console.Write("Ingrese el precio del producto: ");
        double precio = double.Parse(Console.ReadLine());
        preciosProductos.Add(precio);
        Console.WriteLine($"Ha ingresado {preciosProductos.Count} productos");
        Console.WriteLine("Presione enter para continuar...");
        Console.ReadKey();
    }

    static double CalcularTotal(List<double> preciosProductos)
    {
        double total = 0;
        foreach (double precio in preciosProductos)
        {
            total += precio;
        }
        if (total >= 200)
        {
            double descuento = total * 0.10;
            total -= descuento;
            Console.WriteLine($"El total de la compra es {total}, por la compra mayor a Q200.00 se le ha aplicado un descuento del 10%");
        }
        else
        {
            Console.WriteLine($"El total de la compra es: {total}");
        }
        Console.WriteLine("Presione enter para continuar...");
        Console.ReadKey();
        return total;
    }
}
