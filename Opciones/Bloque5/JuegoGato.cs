namespace Opciones.Bloque5
{
    public class JuegoGato
    {
        public void Ejecutar()
        {
            Console.Clear();
            char[,] tablero = new char[3,3];
            for (int i = 0; i < 3; i++) for (int j = 0; j < 3; j++) tablero[i,j] = ' ';
            int turnos = 0;
            char actual = 'X';
            while (true)
            {
                Console.WriteLine("Tablero:");
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                        Console.Write(tablero[i,j] + (j<2 ? " | " : ""));
                    Console.WriteLine();
                    if (i<2) Console.WriteLine("---------");
                }
                Console.WriteLine($"Turno de {actual}. Ingrese fila y columna (1-3):");
                int fila = Convert.ToInt32(Console.ReadLine())-1;
                int col = Convert.ToInt32(Console.ReadLine())-1;
                if (fila<0 || fila>2 || col<0 || col>2 || tablero[fila,col]!=' ')
                {
                    Console.WriteLine("Movimiento inválido.");
                    continue;
                }
                tablero[fila,col] = actual;
                turnos++;
                if (Ganador(tablero,actual))
                {
                    Console.WriteLine($"¡{actual} ha ganado!");
                    break;
                }
                if (turnos==9)
                {
                    Console.WriteLine("Empate.");
                    break;
                }
                actual = actual=='X' ? 'O' : 'X';
            }
            Console.WriteLine("¿Desea reiniciar? (s/n): ");
            if (Console.ReadLine().ToLower()=="s") Ejecutar();
            else { Console.WriteLine("Presione cualquier tecla para volver al menú..."); Console.ReadKey(); }
        }
        private bool Ganador(char[,] t, char a)
        {
            for (int i = 0; i < 3; i++)
                if ((t[i,0]==a && t[i,1]==a && t[i,2]==a) || (t[0,i]==a && t[1,i]==a && t[2,i]==a)) return true;
            if ((t[0,0]==a && t[1,1]==a && t[2,2]==a) || (t[0,2]==a && t[1,1]==a && t[2,0]==a)) return true;
            return false;
        }
    }
}
