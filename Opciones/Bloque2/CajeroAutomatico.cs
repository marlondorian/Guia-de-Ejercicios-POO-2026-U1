namespace Opciones.Bloque2
{
    public class CajeroAutomatico
    {
        public void Ejecutar()
        {
            Console.Clear();
            double saldo = 5000; // Saldo inicial
            Console.WriteLine("--- Cajero Automático ---");
            Console.WriteLine($"Saldo disponible: L{saldo:F2}");
            Console.Write("Ingrese el monto a retirar (múltiplo de 20): L");
            int monto = Convert.ToInt32(Console.ReadLine());
            if (monto % 20 != 0)
            {
                Console.WriteLine("El monto debe ser múltiplo de 20.");
            }
            else if (monto > saldo)
            {
                Console.WriteLine("Fondos insuficientes.");
            }
            else
            {
                int[] billetes = { 500, 200, 100, 50, 20 };
                int[] cantidad = new int[billetes.Length];
                int restante = monto;
                for (int i = 0; i < billetes.Length; i++)
                {
                    cantidad[i] = restante / billetes[i];
                    restante %= billetes[i];
                }
                Console.WriteLine("Desglose de billetes:");
                for (int i = 0; i < billetes.Length; i++)
                {
                    if (cantidad[i] > 0)
                        Console.WriteLine($"{cantidad[i]} billete(s) de L{billetes[i]}");
                }
                saldo -= monto;
                Console.WriteLine($"Nuevo saldo: L{saldo:F2}");
            }
            Console.WriteLine("Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }
    }
}
