namespace Opciones.Bloque1
{
    public class ConversionTemp
    {
        private float fahrenheit_A_celsius(float fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
        private float celsius_A_fahrenheit(float celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
        private float kelvin_A_celsius(float kelvin)
        {
            return kelvin - 273.15f;
        }
        private float celsius_A_kelvin(float celsius)
        {
            return celsius + 273.15f;
        }
        private float fahrenheit_A_kelvin(float fahrenheit)
        {
            float celsius = fahrenheit_A_celsius(fahrenheit);
            return celsius_A_kelvin(celsius);
        }
        private float kelvin_A_fahrenheit(float kelvin)
        {
            float celsius = kelvin_A_celsius(kelvin);
            return celsius_A_fahrenheit(celsius);
        }
        public void Ejecutar()
        {
            
            Console.Clear();
            Console.WriteLine("Seleccione la temperatura original");
            Console.WriteLine("1. Celsius");
            Console.WriteLine("2. Fahrenheit");
            Console.WriteLine("3. Kelvin");
            int opcion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Seleccione la temperatura a convertir");
            switch(opcion){
                case 1:
                    Console.WriteLine("1. Fahrenheit");
                    Console.WriteLine("2. Kelvin");
                    break;
                case 2:
                    Console.WriteLine("1. Celsius");
                    Console.WriteLine("2. Kelvin");
                    break;
                case 3:
                    Console.WriteLine("1. Celsius");
                    Console.WriteLine("2. Fahrenheit");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    return;
            }
            int opcion2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ingrese la temperatura en {(opcion == 1 ? "Celsius" : opcion == 2 ? "Fahrenheit" : "Kelvin")}:");
            float temperatura = Convert.ToSingle(Console.ReadLine());
            float temperatura2 = 0;
            switch ($"{opcion}"+$"{opcion2}")
            {
                case "11":
                    temperatura2 = fahrenheit_A_celsius(temperatura);
                    break;
                case "12":
                    temperatura2 = celsius_A_kelvin(temperatura);
                    break;
                case "21":
                    temperatura2 = celsius_A_fahrenheit(temperatura);
                    break;
                case "22":
                    temperatura2 = fahrenheit_A_kelvin(temperatura);
                    break;
                case "31":
                    temperatura2 = kelvin_A_celsius(temperatura);
                    break;
                case "32":
                    temperatura2 = kelvin_A_fahrenheit(temperatura);
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            Console.WriteLine($"La temperatura convertida es: {temperatura2:F2}");
            Console.WriteLine("Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }
    }
}