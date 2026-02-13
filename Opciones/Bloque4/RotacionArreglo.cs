namespace Opciones.Bloque4
{
    public class RotacionArreglo
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.Write("Ingrese el tamaño del arreglo: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elemento {i+1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("1. Rotar K posiciones a la izquierda");
            Console.WriteLine("2. Rotar K posiciones a la derecha");
            Console.WriteLine("3. Invertir arreglo");
            Console.Write("Seleccione una opción: ");
            int op = Convert.ToInt32(Console.ReadLine());
            if (op == 1 || op == 2)
            {
                Console.Write("Ingrese K: ");
                int k = Convert.ToInt32(Console.ReadLine()) % n;
                if (op == 1)
                    arr = arr.Skip(k).Concat(arr.Take(k)).ToArray();
                else
                    arr = arr.Skip(n - k).Concat(arr.Take(n - k)).ToArray();
            }
            else if (op == 3)
            {
                Array.Reverse(arr);
            }
            Console.WriteLine("Resultado: " + string.Join(", ", arr));
            Console.WriteLine("Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }
    }
}
