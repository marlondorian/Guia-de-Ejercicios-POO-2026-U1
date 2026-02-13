namespace Opciones.Bloque3
{
    public class SerieFibonacci
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Serie Fibonacci ---");
            Console.Write("Ingrese la cantidad de términos: ");
            int n = Convert.ToInt32(Console.ReadLine());
            long a = 0, b = 1, suma = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");
                suma += a;
                long temp = a + b;
                a = b;
                b = temp;
            }
            double promedio = n > 0 ? (double)suma / n : 0;
            Console.WriteLine($"\nSuma: {suma}, Promedio: {promedio:F2}");
            Console.WriteLine("Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }
    }
}
