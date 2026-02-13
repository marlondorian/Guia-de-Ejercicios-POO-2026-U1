namespace Opciones.Bloque1
{
    public class CalculadoraPrestamoSimple
    {
        public void Ejecutar()
        {
            Console.WriteLine("--- Calculadora de Préstamo Simple ---");
            Console.Write("Ingrese el monto del préstamo: ");
            double monto = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la tasa de interés anual (%): ");
            double tasaAnual = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el plazo en meses: ");
            int plazoMeses = Convert.ToInt32(Console.ReadLine());

            double interesTotal = monto * (tasaAnual / 100) * (plazoMeses / 12.0);
            double cuotaMensual = (monto + interesTotal) / plazoMeses;

            Console.WriteLine($"\nInterés total a pagar: {interesTotal:F2}");
            Console.WriteLine($"Cuota mensual fija: {cuotaMensual:F2}");
            Console.WriteLine("Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }
    }
}
