namespace Opciones.Bloque1
{
    public class ConversionUnidadesAlmacenamiento
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Conversión de Unidades de Almacenamiento ---");
            Console.WriteLine("Unidades disponibles: 1. Bytes  2. KB  3. MB  4. GB  5. TB");
            Console.Write("Ingrese el número de la unidad de origen: ");
            int origen = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el número de la unidad de destino: ");
            int destino = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese la cantidad a convertir: ");
            double cantidad = Convert.ToDouble(Console.ReadLine());

            double bytes = cantidad * Math.Pow(1024, origen - 1);
            double resultado = bytes / Math.Pow(1024, destino - 1);

            string[] unidades = {"Bytes", "KB", "MB", "GB", "TB"};
            if (origen < 1 || origen > 5 || destino < 1 || destino > 5 || cantidad < 0)
            {
                Console.WriteLine("Datos inválidos. Intente de nuevo.");
            }
            else
            {
                Console.WriteLine($"{cantidad} {unidades[origen-1]} = {resultado:F4} {unidades[destino-1]}");
            }
            Console.WriteLine("Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }
    }
}
