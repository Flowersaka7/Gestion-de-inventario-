using System;

class Program
{
    static void Main()
    {
        Inventario inventario = new Inventario();
        Cliente cliente = new Cliente("C001", "Joshua F", "Error404@example.com");

        int opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("📋 Menú Principal - Gestión de Inventario");
            Console.WriteLine("1. Agregar Artículo");
            Console.WriteLine("2. Mostrar Inventario");
            Console.WriteLine("3. Buscar Artículo");
            Console.WriteLine("4. Modificar Artículo");
            Console.WriteLine("5. Mostrar Cliente");
            Console.WriteLine("6. Salir");
            Console.Write("Seleccione una opción: ");
            bool valido = int.TryParse(Console.ReadLine(), out opcion);

            Console.WriteLine();

            switch (opcion)
            {
                case 1:
                    Console.Write("Código: ");
                    string cod = Console.ReadLine();
                    Console.Write("Nombre: ");
                    string nom = Console.ReadLine();
                    Console.Write("Precio: ");
                    decimal pre = decimal.Parse(Console.ReadLine());
                    Console.Write("Stock: ");
                    int stk = int.Parse(Console.ReadLine());

                    Articulo nuevo = new Articulo(cod, nom, pre, stk);
                    inventario.AgregarArticulo(nuevo);
                    Console.ReadKey();
                    break;

                case 2:
                    inventario.MostrarInventario();
                    Console.ReadKey();
                    break;

                case 3:
                    Console.Write("Ingrese código a buscar: ");
                    string buscar = Console.ReadLine();
                    var art = inventario.BuscarArticulo(buscar);
                    if (art != null) art.MostrarInfo();
                    else Console.WriteLine("❌ Artículo no encontrado.");
                    Console.ReadKey();
                    break;

                case 4:
                    Console.Write("Código del artículo a modificar: ");
                    string codMod = Console.ReadLine();
                    Console.Write("Nuevo nombre: ");
                    string nuevoNombre = Console.ReadLine();
                    Console.Write("Nuevo precio: ");
                    decimal nuevoPrecio = decimal.Parse(Console.ReadLine());
                    Console.Write("Nuevo stock: ");
                    int nuevoStock = int.Parse(Console.ReadLine());

                    inventario.ModificarArticulo(codMod, nuevoNombre, nuevoPrecio, nuevoStock);
                    Console.ReadKey();
                    break;


                case 5:
                    cliente.MostrarCliente();
                    Console.ReadKey();
                    break;

                case 6:
                    Console.WriteLine("👋 Saliendo del sistema...");
                    break;

                default:
                    Console.WriteLine("❗ Opción no válida.");
                    Console.ReadKey();
                    break;
            }

        } while (opcion != 6);
    }
}
