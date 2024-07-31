using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_en_linea_POO
{
    public class Productos
    {
        public string ID { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }

        public Productos(string iD, string nombre, double precio, int stock)
        {
            ID = iD;
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
        }
        public Productos(List<Productos> listaProductos) { }
        public void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("--- MENÚ PRINCIPAL ---");
            Console.WriteLine("1. Ingresar nuevo producto");
            Console.WriteLine("2. Consultar información del producto");
            Console.WriteLine("3. Venta de producto");
            Console.WriteLine("4. Reabastecer stock");
            Console.WriteLine("5. Actualizar precio");
            Console.WriteLine("6. Salir");
            Console.Write("Ingrese una opción: ");
        }
        public void IngresarProductos(List<Productos> listaProductos)
        {
            Console.Clear();
            Console.WriteLine("--- INGRESAR PRODUCTOS ---");
            Console.Write("ID: ");
            string id = Console.ReadLine() ?? "";
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine()??"";
            Console.Write("Precio: ");
            double precio = double.Parse(Console.ReadLine()??"");
            Console.Write("Cantidad: ");
            int stock = int.Parse(Console.ReadLine()??"");
            listaProductos.Add(new Productos(id, nombre, precio, stock));
            Console.WriteLine("\nEl producto se ha añadido correctamente");
            Console.WriteLine("\nPresione Enter para continuar");
            Console.ReadKey();
        }
        public void ConsultarInformacion(List<Productos> listaProductos)
        {
            Console.Clear();
            Console.WriteLine("--- CONSULTAR INFORMACIÓN ---");
            Console.Write("ID: ");
            string iD = Console.ReadLine() ?? "";
            Productos? productoBuscar = listaProductos.Find(x=>x.ID == iD);
            if (productoBuscar != null)
            {
                Console.WriteLine("Producto Encontrado");
                Console.WriteLine($"\nID: {productoBuscar.ID}\nNombre: {productoBuscar.Nombre}\nPrecio: {productoBuscar.Precio}\nStock: {productoBuscar.Stock}");
                Console.WriteLine("\nPresione Enter para continuar");
                Console.ReadKey();
            }else
            {
                Console.WriteLine("El producto no ha sido encontrado");
                Console.WriteLine("\nPresione Enter para continuar");
                Console.ReadKey();
            }
        }
        public void VentaProducto(List<Productos> listaProductos)
        {
            Console.Clear();
            Console.WriteLine("---  VENTA DE PRODUCTOS ---");
            Console.Write("ID: ");
            string iD = Console.ReadLine() ?? "";
            Productos? productoBuscar = listaProductos.Find(x => x.ID == iD);
            if (productoBuscar != null)
            {
                Console.Write("Cantidad: ");
                int stock = int.Parse(Console.ReadLine()??"");
                if (productoBuscar.Stock > 0)
                {
                    productoBuscar.Stock -= stock;
                    Console.WriteLine("\nVenta realizada con éxito");
                    Console.WriteLine("\nPresione Enter para continuar");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Producto sin existencia");
                    Console.WriteLine("\nPresione Enter para continuar");
                    Console.ReadKey(); 
                }
            }
            else
            {
                Console.WriteLine("El producto no ha sido encontrado");
                Console.WriteLine("\nPresione Enter para continuar");
                Console.ReadKey();
            }
        }
        public void ReabastecerProductos(List<Productos> listaProductos)
        {
            Console.Clear();
            Console.WriteLine("---  REABASTECER PRODUCTOS ---");
            Console.Write("ID: ");
            string iD = Console.ReadLine() ?? "";
            Productos? productoBuscar = listaProductos.Find(x => x.ID == iD);
            if (productoBuscar != null)
            {
                Console.Write("Cantidad: ");
                int stock = int.Parse(Console.ReadLine() ?? "");
                if (stock > 0)
                {
                    productoBuscar.Stock += stock;
                    Console.WriteLine("\nProducto reabastecido con éxito");
                    Console.WriteLine("\nPresione Enter para continuar");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Ingrese un valor mayor a 0");
                    Console.WriteLine("\nPresione Enter para continuar");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("El producto no ha sido encontrado");
                Console.WriteLine("\nPresione Enter para continuar");
                Console.ReadKey();
            }
        }
        public void ActualizarPrecio(List<Productos> listaProductos)
        {
            Console.Clear();
            Console.WriteLine("---  ACTUALIZAR PRECIO  ---");
            Console.Write("ID: ");
            string iD = Console.ReadLine() ?? "";
            Productos? productoBuscar = listaProductos.Find(x => x.ID == iD);
            if (productoBuscar != null)
            {
                Console.Write("Precio: ");
                double precio = double.Parse(Console.ReadLine() ??"");
                if (precio > 0)
                {
                    productoBuscar.Precio = precio;
                    Console.WriteLine("\nPrecio del producto actualizado con éxito");
                    Console.WriteLine("\nPresione Enter para continuar");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Ingrese un valor mayor a cero");
                    Console.WriteLine("\nPresione Enter para continuar");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("El producto no ha sido encontrado");
                Console.WriteLine("\nPresione Enter para continuar");
                Console.ReadKey();
            }
        }
    } 
}
