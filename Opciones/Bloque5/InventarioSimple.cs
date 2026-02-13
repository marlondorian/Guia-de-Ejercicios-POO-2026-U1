namespace Opciones.Bloque5
{
    public class InventarioSimple
    {
        public void Ejecutar()
        {
            Console.Clear();
            int n = 5;
            int[] codigos = new int[n];
            string[] nombres = new string[n];
            int[] cantidades = new int[n];
            double[] precios = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Producto {i+1}:");
                Console.Write("Código: "); codigos[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nombre: "); nombres[i] = Console.ReadLine();
                Console.Write("Cantidad: "); cantidades[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Precio: "); precios[i] = Convert.ToDouble(Console.ReadLine());
            }
            do
            {
                Console.WriteLine("1. Mostrar inventario");
                Console.WriteLine("2. Buscar producto");
                Console.WriteLine("3. Actualizar cantidad");
                Console.WriteLine("4. Calcular valor total");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");
                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        for (int i = 0; i < n; i++)
                            Console.WriteLine($"{codigos[i]} - {nombres[i]} - {cantidades[i]} - L{precios[i]:F2}");
                        break;
                    case 2:
                        Console.Write("Ingrese código a buscar: ");
                        int c = Convert.ToInt32(Console.ReadLine());
                        int idx = Array.IndexOf(codigos, c);
                        if (idx >= 0)
                            Console.WriteLine($"{codigos[idx]} - {nombres[idx]} - {cantidades[idx]} - L{precios[idx]:F2}");
                        else
                            Console.WriteLine("No encontrado.");
                        break;
                    case 3:
                        Console.Write("Ingrese código a actualizar: ");
                        int ca = Convert.ToInt32(Console.ReadLine());
                        int idxa = Array.IndexOf(codigos, ca);
                        if (idxa >= 0)
                        {
                            Console.Write("Nueva cantidad: ");
                            cantidades[idxa] = Convert.ToInt32(Console.ReadLine());
                        }
                        else
                            Console.WriteLine("No encontrado.");
                        break;
                    case 4:
                        double total = 0;
                        for (int i = 0; i < n; i++) total += cantidades[i] * precios[i];
                        Console.WriteLine($"Valor total: L{total:F2}");
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            } while (true);
        }
    }
}
