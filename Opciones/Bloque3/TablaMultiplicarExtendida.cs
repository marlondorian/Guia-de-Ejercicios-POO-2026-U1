namespace Opciones.Bloque3
{
    public class TablaMultiplicarExtendida
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Tabla de Multiplicar Extendida ---");
            Console.Write("Ingrese un número: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Tabla del {n}:");
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{n,2} x {i,2} = {n*i,3}");
            }
            Console.WriteLine("Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }
    }
}
