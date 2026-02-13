namespace Opciones.Bloque2
{
    public class AnioBisiestoDiasMes
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Año Bisiesto y Días del Mes ---");
            Console.Write("Ingrese el año: ");
            int anio = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el mes (1-12): ");
            int mes = Convert.ToInt32(Console.ReadLine());
            bool bisiesto = (anio % 4 == 0 && (anio % 100 != 0 || anio % 400 == 0));
            int dias = 0;
            switch (mes)
            {
                case 2:
                    dias = bisiesto ? 29 : 28;
                    break;
                case 4: case 6: case 9: case 11:
                    dias = 30;
                    break;
                default:
                    dias = 31;
                    break;
            }
            Console.WriteLine(bisiesto ? "El año es bisiesto." : "El año no es bisiesto.");
            Console.WriteLine($"El mes tiene {dias} días.");
            Console.WriteLine("Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }
    }
}
