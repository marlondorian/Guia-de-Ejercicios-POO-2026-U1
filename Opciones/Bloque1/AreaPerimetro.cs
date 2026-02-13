namespace Opciones.Bloque1
{
    public class AreaPerimetro
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Cálculo de Área y Perímetro ---");
            Console.WriteLine("1. Círculo");
            Console.WriteLine("2. Triángulo");
            Console.WriteLine("3. Rectángulo");
            Console.WriteLine("4. Trapecio");
            Console.WriteLine("5. Volver al menú");
            Console.Write("Seleccione una opción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    CalcularCirculo();
                    break;
                case 2:
                    CalcularTriangulo();
                    break;
                case 3:
                    CalcularRectangulo();
                    break;
                case 4:
                    CalcularTrapecio();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
            Console.WriteLine("Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }

        private void CalcularCirculo()
        {
            double radio = LeerPositivo("Ingrese el radio del círculo: ");
            double area = Math.PI * radio * radio;
            double perimetro = 2 * Math.PI * radio;
            Console.WriteLine($"Área: {area:F2}, Perímetro: {perimetro:F2}");
        }

        private void CalcularTriangulo()
        {
            double baseT = LeerPositivo("Ingrese la base del triángulo: ");
            double altura = LeerPositivo("Ingrese la altura del triángulo: ");
            double lado1 = LeerPositivo("Ingrese el lado 1 del triángulo: ");
            double lado2 = LeerPositivo("Ingrese el lado 2 del triángulo: ");
            double area = (baseT * altura) / 2;
            double perimetro = baseT + lado1 + lado2;
            Console.WriteLine($"Área: {area:F2}, Perímetro: {perimetro:F2}");
        }

        private void CalcularRectangulo()
        {
            double baseR = LeerPositivo("Ingrese la base del rectángulo: ");
            double altura = LeerPositivo("Ingrese la altura del rectángulo: ");
            double area = baseR * altura;
            double perimetro = 2 * (baseR + altura);
            Console.WriteLine($"Área: {area:F2}, Perímetro: {perimetro:F2}");
        }

        private void CalcularTrapecio()
        {
            double baseMayor = LeerPositivo("Ingrese la base mayor del trapecio: ");
            double baseMenor = LeerPositivo("Ingrese la base menor del trapecio: ");
            double altura = LeerPositivo("Ingrese la altura del trapecio: ");
            double lado1 = LeerPositivo("Ingrese el lado 1 del trapecio: ");
            double lado2 = LeerPositivo("Ingrese el lado 2 del trapecio: ");
            double area = ((baseMayor + baseMenor) * altura) / 2;
            double perimetro = baseMayor + baseMenor + lado1 + lado2;
            Console.WriteLine($"Área: {area:F2}, Perímetro: {perimetro:F2}");
        }

        private double LeerPositivo(string mensaje)
        {
            double valor;
            do
            {
                Console.Write(mensaje);
                if (!double.TryParse(Console.ReadLine(), out valor) || valor <= 0)
                {
                    Console.WriteLine("Valor inválido. Debe ser un número positivo.");
                }
            } while (valor <= 0);
            return valor;
        }
    }
}
