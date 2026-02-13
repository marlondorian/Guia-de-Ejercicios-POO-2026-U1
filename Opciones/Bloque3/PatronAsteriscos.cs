namespace Opciones.Bloque3
{
    public class PatronAsteriscos
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Patrón de Asteriscos ---");
            Console.WriteLine("1. Triángulo");
            Console.WriteLine("2. Triángulo invertido");
            Console.WriteLine("3. Rombo");
            Console.WriteLine("4. Cuadrado hueco");
            Console.Write("Seleccione un patrón: ");
            int op = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el tamaño: ");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    for (int i = 1; i <= n; i++)
                        Console.WriteLine(new string('*', i));
                    break;
                case 2:
                    for (int i = n; i >= 1; i--)
                        Console.WriteLine(new string('*', i));
                    break;
                case 3:
                    for (int i = 1; i <= n; i++)
                        Console.WriteLine(new string(' ', n - i) + new string('*', 2 * i - 1));
                    for (int i = n - 1; i >= 1; i--)
                        Console.WriteLine(new string(' ', n - i) + new string('*', 2 * i - 1));
                    break;
                case 4:
                    for (int i = 1; i <= n; i++)
                    {
                        if (i == 1 || i == n)
                            Console.WriteLine(new string('*', n));
                        else
                            Console.WriteLine("*" + new string(' ', n - 2) + "*");
                    }
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
            Console.WriteLine("Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }
    }
}
