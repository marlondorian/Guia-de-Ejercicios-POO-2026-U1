namespace Opciones.Bloque3
{
    public class MenuBloque3
    {
        public void Ejecutar()
        {
            Console.Clear();
            do
            {
                try
                {
                    Console.WriteLine("=BLOQUE 3 - MENÚ DE OPCIONES=");
                    Console.WriteLine("15. Tabla de multiplicar extendida");
                    Console.WriteLine("16. Números primos en rango");
                    Console.WriteLine("17. Serie Fibonacci");
                    Console.WriteLine("18. Factorial y combinaciones");
                    Console.WriteLine("19. Juego de adivinanza");
                    Console.WriteLine("20. Validación de contraseña");
                    Console.WriteLine("21. Patrón de asteriscos");
                    Console.WriteLine("22. Calculadora con menú");
                    Console.WriteLine("23. Volver al menú principal");
                    Console.Write("Seleccione una opción: ");
                    int opcion = Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                    {
                        case 15:
                            new TablaMultiplicarExtendida().Ejecutar();
                            break;
                        case 16:
                            new NumerosPrimosEnRango().Ejecutar();
                            break;
                        case 17:
                            new SerieFibonacci().Ejecutar();
                            break;
                        case 18:
                            new FactorialCombinaciones().Ejecutar();
                            break;
                        case 19:
                            new JuegoAdivinanza().Ejecutar();
                            break;
                        case 20:
                            new ValidacionContrasena().Ejecutar();
                            break;
                        case 21:
                            new PatronAsteriscos().Ejecutar();
                            break;
                        case 22:
                            new CalculadoraConMenu().Ejecutar();
                            break;
                        case 23:
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
