// Calculadora de IMC
namespace Opciones.Bloque1
{
    public class CalculadoraIMC
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("Calculadora de IMC");
            Console.WriteLine("Ingrese su peso en kilogramos:");
            float peso = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Ingrese su altura en metros:");
            float altura = Convert.ToSingle(Console.ReadLine());

            float imc = peso / (altura * altura);
            Console.WriteLine($"Su IMC es: {imc:F2}");

            if (imc < 18.5)
            {
                Console.WriteLine("Categoría: Bajo peso");
            }
            else if (imc >= 18.5 && imc < 25)
            {
                Console.WriteLine("Categoría: Peso normal");
            }
            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("Categoría: Sobrepeso");
            }
            else
            {
                Console.WriteLine("Categoría: Obesidad");
            }

            Console.WriteLine("Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }
    }
}