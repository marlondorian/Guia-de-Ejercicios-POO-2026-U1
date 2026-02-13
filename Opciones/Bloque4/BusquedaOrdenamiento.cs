namespace Opciones.Bloque4
{
    public class BusquedaOrdenamiento
    {
        public void Ejecutar()
        {
            Console.Clear();
            int[] arr = new int[10];
            Console.WriteLine("Ingrese 10 enteros:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Elemento {i+1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Ingrese valor a buscar: ");
            int buscar = Convert.ToInt32(Console.ReadLine());
            int pos = Array.IndexOf(arr, buscar);
            Console.WriteLine(pos >= 0 ? $"Encontrado en posición {pos}" : "No encontrado");
            int max = arr.Max(), segundo = arr.Where(x => x != max).DefaultIfEmpty(max).Max();
            Console.WriteLine($"Segundo mayor: {segundo}");
            // Burbuja
            for (int i = 0; i < arr.Length-1; i++)
                for (int j = 0; j < arr.Length-i-1; j++)
                    if (arr[j] > arr[j+1]) { int t = arr[j]; arr[j] = arr[j+1]; arr[j+1] = t; }
            Console.WriteLine("Arreglo ordenado: " + string.Join(", ", arr));
            Console.WriteLine("Elementos en posiciones pares:");
            for (int i = 0; i < arr.Length; i += 2)
                Console.Write(arr[i] + " ");
            Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }
    }
}
