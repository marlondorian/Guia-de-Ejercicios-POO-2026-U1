namespace Opciones.Bloque2
{
    public class MenuBloque2
    {
        public void Ejecutar()
        {
            do
            {
                try
                {
                    Console.WriteLine("=BLOQUE 2 - MENÚ DE OPCIONES=");
                    Console.WriteLine("9. Clasificación de triángulos");
                    Console.WriteLine("10. Sistema de calificaciones UNAH");
                    Console.WriteLine("11. Calculadora de descuentos");
                    Console.WriteLine("12. Año bisiesto y días del mes");
                    Console.WriteLine("13. Validador de fecha");
                    Console.WriteLine("14. Cajero automático");
                    Console.WriteLine("15. Volver al menú principal");
                    Console.Write("Seleccione una opción: ");
                    int opcion = Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                    {
                        case 9:
                            new ClasificacionTriangulos().Ejecutar();
                            break;
                        case 10:
                            new SistemaCalificacionesUNAH().Ejecutar();
                            break;
                        case 11:
                            new CalculadoraDescuentos().Ejecutar();
                            break;
                        case 12:
                            new AnioBisiestoDiasMes().Ejecutar();
                            break;
                        case 13:
                            new ValidadorFecha().Ejecutar();
                            break;
                        case 14:
                            new CajeroAutomatico().Ejecutar();
                            break;
                        case 15:
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
