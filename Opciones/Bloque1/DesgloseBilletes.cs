namespace Opciones.Bloque1
{
    public class DesgloseBilletes
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el monto a desglosar:");
            int monto = Convert.ToInt32(Console.ReadLine());

            int[] billetes = { 500, 100, 50, 20, 10, 5, 2, 1 };
            int[] cantidadBilletes = new int[billetes.Length];

            for (int i = 0; i < billetes.Length; i++)
            {
                cantidadBilletes[i] = monto / billetes[i];
                // Console.WriteLine($"{billetes[i]}: {monto} {cantidadBilletes[i]}");
                monto %= billetes[i];
                // Console.WriteLine($"{billetes[i]} {monto} {cantidadBilletes[i]}");
            }

            Console.WriteLine("Desglose de billetes:");
            for (int i = 0; i < billetes.Length; i++)
            {
                if (cantidadBilletes[i] > 0)
                {
                    Console.WriteLine($"{cantidadBilletes[i]} billete(s) de {billetes[i]}");
                }
            }

            Console.WriteLine("Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }
    }
    
}