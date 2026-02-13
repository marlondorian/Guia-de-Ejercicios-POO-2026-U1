namespace Opciones.Bloque5
{
    public class MenuBloque5
    {
        public void Ejecutar()
        {
            Console.Clear();
            do
            {
                try
                {
                    Console.WriteLine("=BLOQUE 5 - MENÚ DE OPCIONES=");
                    Console.WriteLine("28. Matriz de notas por parcial");
                    Console.WriteLine("29. Juego de Gato (Tic-Tac-Toe)");
                    Console.WriteLine("30. Inventario simple");
                    Console.WriteLine("31. Volver al menú principal");
                    Console.Write("Seleccione una opción: ");
                    int opcion = Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                    {
                        case 28:
                            new MatrizNotasPorParcial().Ejecutar();
                            break;
                        case 29:
                            new JuegoGato().Ejecutar();
                            break;
                        case 30:
                            new InventarioSimple().Ejecutar();
                            break;
                        case 31:
                            return;
                        default:
                            Console.WriteLine("Opción no válida. Intente de nuevo.");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Ingrese un valor válido.");
                }
            } while (true);
        }
    }
}
