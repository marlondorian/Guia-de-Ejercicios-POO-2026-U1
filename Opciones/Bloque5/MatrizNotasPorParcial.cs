namespace Opciones.Bloque5
{
    public class MatrizNotasPorParcial
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.Write("Ingrese cantidad de estudiantes: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[,] notas = new double[n,3];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Estudiante {i+1}:");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Parcial {j+1}: ");
                    notas[i,j] = Convert.ToDouble(Console.ReadLine());
                }
            }
            double[] promsEst = new double[n];
            for (int i = 0; i < n; i++) promsEst[i] = (notas[i,0]+notas[i,1]+notas[i,2])/3.0;
            double[] promsParc = new double[3];
            for (int j = 0; j < 3; j++) promsParc[j] = Enumerable.Range(0,n).Select(i=>notas[i,j]).Average();
            int mejor = Array.IndexOf(promsEst, promsEst.Max())+1;
            int dificil = Array.IndexOf(promsParc, promsParc.Min())+1;
            Console.WriteLine("Promedio por estudiante:");
            for (int i = 0; i < n; i++) Console.WriteLine($"Estudiante {i+1}: {promsEst[i]:F2}");
            Console.WriteLine("Promedio por parcial:");
            for (int j = 0; j < 3; j++) Console.WriteLine($"Parcial {j+1}: {promsParc[j]:F2}");
            Console.WriteLine($"Mejor promedio: Estudiante {mejor}");
            Console.WriteLine($"Parcial más difícil: {dificil}");
            Console.WriteLine("Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }
    }
}
