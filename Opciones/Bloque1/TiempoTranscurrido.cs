namespace Opciones.Bloque1
{
    public class TiempoTranscurrido
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Tiempo transcurrido entre dos horas (formato 24h) ---");
            Console.Write("Ingrese la primera hora (HH:MM:SS): ");
            string hora1 = Console.ReadLine();
            Console.Write("Ingrese la segunda hora (HH:MM:SS): ");
            string hora2 = Console.ReadLine();

            if (TimeSpan.TryParse(hora1, out TimeSpan t1) && TimeSpan.TryParse(hora2, out TimeSpan t2))
            {
                TimeSpan diferencia = t2 - t1;
                if (diferencia < TimeSpan.Zero)
                    diferencia += TimeSpan.FromDays(1); // Si cruza medianoche

                Console.WriteLine($"Diferencia: {diferencia.Hours} horas, {diferencia.Minutes} minutos, {diferencia.Seconds} segundos");
            }
            else
            {
                Console.WriteLine("Formato de hora inválido. Use HH:MM:SS");
            }
            Console.WriteLine("Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }
    }
}
