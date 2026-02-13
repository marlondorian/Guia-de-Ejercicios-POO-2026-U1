namespace Opciones.Bloque4
{
    public class MenuBloque4
    {
        public void Ejecutar()
        {
            Console.Clear();
            do
            {
                try
                {
                    Console.WriteLine("=BLOQUE 4 - MENÚ DE OPCIONES=");
                    Console.WriteLine("23. Estadísticas de calificaciones");
                    Console.WriteLine("24. Búsqueda y ordenamiento");
                    Console.WriteLine("25. Rotación de arreglo");
                    Console.WriteLine("26. Frecuencia de elementos");
                    Console.WriteLine("27. Arreglo de temperaturas");
                    Console.WriteLine("28. Volver al menú principal");
                    Console.Write("Seleccione una opción: ");
                    int opcion = Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                    {
                        case 23:
                            new EstadisticasCalificaciones().Ejecutar();
                            break;
                        case 24:
                            new BusquedaOrdenamiento().Ejecutar();
                            break;
                        case 25:
                            new RotacionArreglo().Ejecutar();
                            break;
                        case 26:
                            new FrecuenciaElementos().Ejecutar();
                            break;
                        case 27:
                            new ArregloTemperaturas().Ejecutar();
                            break;
                        case 28:
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
