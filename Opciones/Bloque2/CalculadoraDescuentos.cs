namespace Opciones.Bloque2
{
    public class CalculadoraDescuentos
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Calculadora de Descuentos ---");
            Console.Write("Ingrese el monto de compra: L");
            double monto = Convert.ToDouble(Console.ReadLine());
            double descuento = 0;
            if (monto >= 500 && monto < 1000) descuento = 0.05;
            else if (monto >= 1000 && monto < 2500) descuento = 0.10;
            else if (monto >= 2500) descuento = 0.15;
            double valorDescuento = monto * descuento;
            double precioFinal = monto - valorDescuento;
            Console.WriteLine($"Precio original: L{monto:F2}");
            Console.WriteLine($"Descuento: L{valorDescuento:F2}");
            Console.WriteLine($"Precio final: L{precioFinal:F2}");
            Console.WriteLine("Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }
    }
}
