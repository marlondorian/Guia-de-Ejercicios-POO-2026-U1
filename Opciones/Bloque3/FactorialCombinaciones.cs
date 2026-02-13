namespace Opciones.Bloque3
{
    public class FactorialCombinaciones
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Factorial y Combinaciones ---");
            Console.Write("Ingrese n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese r: ");
            int r = Convert.ToInt32(Console.ReadLine());
            long factN = Factorial(n);
            long factR = Factorial(r);
            long factNR = Factorial(n - r);
            long combinaciones = (r >= 0 && n >= r) ? factN / (factR * factNR) : 0;
            Console.WriteLine($"{n}! = {factN}");
            Console.WriteLine($"C({n},{r}) = {combinaciones}");
            Console.WriteLine("Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }
        private long Factorial(int x)
        {
            long res = 1;
            for (int i = 2; i <= x; i++) res *= i;
            return res;
        }
    }
}
