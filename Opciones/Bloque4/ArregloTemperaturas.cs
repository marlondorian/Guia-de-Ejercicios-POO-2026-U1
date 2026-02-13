namespace Opciones.Bloque4
{
    public class ArregloTemperaturas
    {
        public void Ejecutar()
        {
            Console.Clear();
            double[] temps = new double[7];
            for (int i = 0; i < 7; i++)
            {
                Console.Write($"Temperatura día {i+1}: ");
                temps[i] = Convert.ToDouble(Console.ReadLine());
            }
            double prom = temps.Average();
            int sobreProm = temps.Count(x => x > prom);
            int masCaluroso = Array.IndexOf(temps, temps.Max()) + 1;
            int masFrio = Array.IndexOf(temps, temps.Min()) + 1;
            Console.WriteLine($"Promedio semanal: {prom:F2}");
            Console.WriteLine($"Días sobre el promedio: {sobreProm}");
            Console.WriteLine($"Día más caluroso: {masCaluroso}");
            Console.WriteLine($"Día más frío: {masFrio}");
            Console.WriteLine("Variación entre días consecutivos:");
            for (int i = 1; i < 7; i++)
                Console.WriteLine($"Día {i} a {i+1}: {Math.Abs(temps[i]-temps[i-1]):F2}");
            Console.WriteLine("Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }
    }
}
