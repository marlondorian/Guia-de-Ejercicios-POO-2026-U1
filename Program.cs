// See https://aka.ms/new-console-template for more information
Console.Clear();
do
{
    // Menu principal envuelto en un bloque try-catch para manejar caracteres no válidos
    try
    {
        Console.WriteLine("=========MENU=========");
        Console.WriteLine("1. Variables y Operadores (1-8)");
        Console.WriteLine("2. Estructuras de Control - Condicionales (9-14)");
        Console.WriteLine("3. Estructuras de Control - Ciclos (15-22)");
        Console.WriteLine("4. Arreglos Unidimensionales (23-27)");
        Console.WriteLine("5. Arreglos Bidimensionales (28-30)");
        Console.WriteLine("6. Salir");
        int opcion = Convert.ToInt32(Console.ReadLine());
        switch (opcion)
        {
            case 1:
                Opciones.Bloque1.MenuBloque1 opcion1 = new Opciones.Bloque1.MenuBloque1();
                opcion1.Ejecutar();
                break;
            case 2:
                Opciones.Bloque2.MenuBloque2 opcion2 = new Opciones.Bloque2.MenuBloque2();
                opcion2.Ejecutar();
                break;
            case 3:
                Opciones.Bloque3.MenuBloque3 opcion3 = new Opciones.Bloque3.MenuBloque3();
                opcion3.Ejecutar();
                break;
            case 4:
                Opciones.Bloque4.MenuBloque4 opcion4 = new Opciones.Bloque4.MenuBloque4();
                opcion4.Ejecutar();
                break;
            case 5:
                Opciones.Bloque5.MenuBloque5 opcion5 = new Opciones.Bloque5.MenuBloque5();
                opcion5.Ejecutar();
                break;
            case 6:
                Console.WriteLine("Saliendo del programa...");
                return;
            default:
                Console.WriteLine("Opción no válida. Por favor, seleccione una opción del 1 al 5.");
                break;

        }
    }
    catch (System.Exception)
    {
        Console.WriteLine("Ingrese un valor válido.");
    }
} while (true);