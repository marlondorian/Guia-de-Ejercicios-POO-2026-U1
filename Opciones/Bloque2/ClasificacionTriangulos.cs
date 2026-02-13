namespace Opciones.Bloque2
{
    public class ClasificacionTriangulos
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Clasificación de Triángulos ---");
            Console.Write("Ingrese el lado 1: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el lado 2: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el lado 3: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("Los lados deben ser positivos.");
            }
            else if (a + b > c && a + c > b && b + c > a)
            {
                // Clasificación por lados
                if (a == b && b == c)
                    Console.WriteLine("Triángulo equilátero");
                else if (a == b || a == c || b == c)
                    Console.WriteLine("Triángulo isósceles");
                else
                    Console.WriteLine("Triángulo escaleno");

                // Clasificación por ángulos
                double[] lados = {a, b, c};
                Array.Sort(lados);
                double hip = lados[2], cat1 = lados[0], cat2 = lados[1];
                double hip2 = hip * hip, sumaCat2 = cat1 * cat1 + cat2 * cat2;
                if (Math.Abs(hip2 - sumaCat2) < 1e-6)
                    Console.WriteLine("Triángulo rectángulo");
                else if (hip2 < sumaCat2)
                    Console.WriteLine("Triángulo acutángulo");
                else
                    Console.WriteLine("Triángulo obtusángulo");
            }
            else
            {
                Console.WriteLine("No forman un triángulo válido.");
            }
            Console.WriteLine("Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }
    }
}
