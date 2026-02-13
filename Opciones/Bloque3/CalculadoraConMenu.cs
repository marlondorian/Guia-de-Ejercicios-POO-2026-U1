namespace Opciones.Bloque3
{
    public class CalculadoraConMenu
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Calculadora con Menú ---");
            double resultado = 0;
            bool primero = true;
            do
            {
                if (primero)
                {
                    Console.Write("Ingrese el primer número: ");
                    resultado = Convert.ToDouble(Console.ReadLine());
                    primero = false;
                }
                Console.WriteLine($"Resultado actual: {resultado}");
                Console.WriteLine("1. Sumar\n2. Restar\n3. Multiplicar\n4. Dividir\n5. Potencia\n6. Raíz cuadrada\n7. Porcentaje\n8. Salir");
                Console.Write("Seleccione una operación: ");
                int op = Convert.ToInt32(Console.ReadLine());
                if (op == 8) break;
                double valor = 0;
                if (op != 6)
                {
                    Console.Write("Ingrese el siguiente número: ");
                    valor = Convert.ToDouble(Console.ReadLine());
                }
                switch (op)
                {
                    case 1: resultado += valor; break;
                    case 2: resultado -= valor; break;
                    case 3: resultado *= valor; break;
                    case 4: resultado = valor != 0 ? resultado / valor : resultado; break;
                    case 5: resultado = Math.Pow(resultado, valor); break;
                    case 6: resultado = Math.Sqrt(resultado); break;
                    case 7: resultado = resultado * valor / 100.0; break;
                    default: Console.WriteLine("Opción no válida."); break;
                }
            } while (true);
            Console.WriteLine($"Resultado final: {resultado}");
            Console.WriteLine("Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }
    }
}
