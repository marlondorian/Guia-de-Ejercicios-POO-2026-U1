namespace Opciones.Bloque1
{
    public class MenuBloque1
    {
        public void Ejecutar()
        {   Console.Clear();
            do
            {
                
                try
                {
                    Console.WriteLine("=VARIABLES Y OPERADORES=");
                    Console.WriteLine("1. Calculadora de IMC");
                    Console.WriteLine("2. Conversión de temperatura");
                    Console.WriteLine("3. Desglose de billetes");
                    Console.WriteLine("4. Calculadora de préstamo simple");
                    Console.WriteLine("5. Tiempo transcurrido");
                    Console.WriteLine("6. Área y perímetro");
                    Console.WriteLine("7. Conversión de unidades de almacenamiento");
                    Console.WriteLine("8. Cálculo de salario semanal");
                    Console.WriteLine("9: Volver al menú principal");
                    int opcion = Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            new CalculadoraIMC().Ejecutar();
                            break;
                        case 2:
                            new ConversionTemp().Ejecutar();
                            break;
                        case 3:
                            new DesgloseBilletes().Ejecutar();
                            break;
                        case 4:
                            new CalculadoraPrestamoSimple().Ejecutar();
                            break;
                        case 5:
                            new TiempoTranscurrido().Ejecutar();
                            break;
                        case 6:
                            new AreaPerimetro().Ejecutar();
                            break;
                        case 7:
                            new ConversionUnidadesAlmacenamiento().Ejecutar();
                            break;
                        case 8:
                            new CalculoSalarioSemanal().Ejecutar();
                            break;
                        case 9:
                            return;

                        default:
                            Console.WriteLine("Opción no válida. Por favor, seleccione una opción del 1 al 9.");
                            break;


                    }
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Ingrese un valor válido.");
                }
            } while (true);
        }
    }
}