namespace Opciones.Bloque3
{
    public class JuegoAdivinanza
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Juego de Adivinanza (1-100) ---");
            Random rnd = new Random();
            int secreto = rnd.Next(1, 101);
            int intentos = 7, usado = 0;
            bool ganado = false;
            for (int i = 1; i <= intentos; i++)
            {
                Console.Write($"Intento {i}/{intentos}: ");
                int guess = Convert.ToInt32(Console.ReadLine());
                usado++;
                if (guess == secreto)
                {
                    Console.WriteLine("¡Correcto! Has adivinado el número.");
                    ganado = true;
                    break;
                }
                else if (guess < secreto)
                    Console.WriteLine("Mayor");
                else
                    Console.WriteLine("Menor");
            }
            if (!ganado)
                Console.WriteLine($"No adivinaste. El número era {secreto}.");
            Console.WriteLine($"Intentos usados: {usado}");
            Console.WriteLine("Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }
    }
}
