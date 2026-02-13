namespace Opciones.Bloque4
{
    public class FrecuenciaElementos
    {
        public void Ejecutar()
        {
            Console.Clear();
            Random rnd = new Random();
            int[] arr = new int[20];
            for (int i = 0; i < 20; i++) arr[i] = rnd.Next(1, 11);
            var grupos = arr.GroupBy(x => x).Select(g => new { Num = g.Key, Freq = g.Count() }).ToList();
            foreach (var g in grupos)
                Console.WriteLine($"{g.Num}: {g.Freq}");
            int maxF = grupos.Max(g => g.Freq), minF = grupos.Min(g => g.Freq);
            Console.WriteLine("Más frecuente(s): " + string.Join(", ", grupos.Where(g => g.Freq == maxF).Select(g => g.Num)));
            Console.WriteLine("Menos frecuente(s): " + string.Join(", ", grupos.Where(g => g.Freq == minF).Select(g => g.Num)));
            Console.WriteLine("Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }
    }
}
