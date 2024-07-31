// See https://aka.ms/new-console-template for more information

using Tienda_en_linea_POO;

List <Productos > listaProductos = new List <Productos>();
Productos producto = new Productos(listaProductos);
 bool menu = true;

do
{
    try
    {
        producto.MostrarMenu();
        int opcion = int.Parse(Console.ReadLine());
        switch (opcion)
        {
            case 1:
                producto.IngresarProductos(listaProductos);
                break;
            case 2:
                producto.ConsultarInformacion(listaProductos);
                break;
            case 3:
                producto.VentaProducto(listaProductos);
                break;
            case 4:
                producto.ReabastecerProductos(listaProductos);
                break;
            case 5:
                producto.ActualizarPrecio(listaProductos);
                break;
            case 6:
                Console.WriteLine("\nUsted está saliendo del programa...");
                Console.WriteLine("Presione Enter para continuar");
                Console.ReadKey();
                menu = false;
                break;
            default:
                Console.WriteLine("\nIngrese una opción válida");
                Console.WriteLine("Presione Enter para continuar");
                Console.ReadKey();
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
} while (menu);