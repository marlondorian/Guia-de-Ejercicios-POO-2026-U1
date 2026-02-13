namespace Opciones.Bloque4
{
    public class EstadisticasCalificaciones
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Estadísticas de Calificaciones ---");
            Console.Write("¿Cuántas calificaciones desea ingresar?: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] notas = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nota {i+1}: ");
                notas[i] = Convert.ToDouble(Console.ReadLine());
            }
            double promedio = notas.Average();
            double max = notas.Max();
            double min = notas.Min();
            int aprobados = notas.Count(x => x >= 60);
            int reprobados = n - aprobados;
            double desv = Math.Sqrt(notas.Select(x => Math.Pow(x - promedio, 2)).Sum() / n);
            Console.WriteLine($"Promedio: {promedio:F2}, Máxima: {max}, Mínima: {min}");
            Console.WriteLine($"Aprobados: {aprobados}, Reprobados: {reprobados}");
            Console.WriteLine($"Desviación estándar: {desv:F2}");
            Console.WriteLine("Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }
    }
}
