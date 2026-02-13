namespace Opciones.Bloque3
{
    public class NumerosPrimosEnRango
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Números Primos en Rango ---");
            Console.Write("Ingrese el inicio del rango: ");
            int inicio = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el fin del rango: ");
            int fin = Convert.ToInt32(Console.ReadLine());
            int contador = 0;
            for (int n = Math.Max(2, inicio); n <= fin; n++)
            {
                bool primo = true;
                for (int d = 2; d * d <= n; d++)
                {
                    if (n % d == 0) { primo = false; break; }
                }
                if (primo)
                {
                    Console.Write(n + " ");
                    contador++;
                }
            }
            Console.WriteLine($"\nTotal de primos: {contador}");
            Console.WriteLine("Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }
    }
}
