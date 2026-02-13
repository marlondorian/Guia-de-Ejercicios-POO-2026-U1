namespace Opciones.Bloque2
{
    public class ValidadorFecha
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Validador de Fecha ---");
            Console.Write("Ingrese el día: ");
            int dia = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el mes: ");
            int mes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el año: ");
            int anio = Convert.ToInt32(Console.ReadLine());
            bool esValida = true;
            if (mes < 1 || mes > 12 || dia < 1) esValida = false;
            else
            {
                int[] diasMes = { 31, (anio % 4 == 0 && (anio % 100 != 0 || anio % 400 == 0)) ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                if (dia > diasMes[mes - 1]) esValida = false;
            }
            Console.WriteLine(esValida ? "Fecha válida." : "Fecha inválida.");
            Console.WriteLine("Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }
    }
}
