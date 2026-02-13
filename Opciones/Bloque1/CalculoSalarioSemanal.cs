namespace Opciones.Bloque1
{
    public class CalculoSalarioSemanal
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Cálculo de Salario Semanal ---");
            Console.Write("Ingrese las horas trabajadas: ");
            double horas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la tarifa por hora: ");
            double tarifa = Convert.ToDouble(Console.ReadLine());

            double horasNormales = Math.Min(horas, 44);
            double horasExtras = Math.Max(horas - 44, 0);
            double pagoNormal = horasNormales * tarifa;
            double pagoExtra = horasExtras * tarifa * 1.5;
            double total = pagoNormal + pagoExtra;

            Console.WriteLine($"Horas normales: {horasNormales} x {tarifa} = {pagoNormal:F2}");
            Console.WriteLine($"Horas extras: {horasExtras} x {tarifa} x 1.5 = {pagoExtra:F2}");
            Console.WriteLine($"Total a pagar: {total:F2}");
            Console.WriteLine("Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }
    }
}
