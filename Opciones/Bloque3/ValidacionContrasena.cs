using System.Text.RegularExpressions;

namespace Opciones.Bloque3
{
    public class ValidacionContrasena
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Validación de Contraseña ---");
            while (true)
            {
                Console.Write("Ingrese una contraseña: ");
                string pass = Console.ReadLine();
                string faltan = "";
                if (pass.Length < 8) faltan += "Mínimo 8 caracteres. ";
                if (!Regex.IsMatch(pass, "[A-Z]")) faltan += "Al menos una mayúscula. ";
                if (!Regex.IsMatch(pass, "[a-z]")) faltan += "Al menos una minúscula. ";
                if (!Regex.IsMatch(pass, "[0-9]")) faltan += "Al menos un número. ";
                if (!Regex.IsMatch(pass, "[^A-Za-z0-9]")) faltan += "Al menos un carácter especial. ";
                if (faltan == "")
                {
                    Console.WriteLine("Contraseña válida.");
                    break;
                }
                else
                {
                    Console.WriteLine("Faltan requisitos: " + faltan);
                }
            }
            Console.WriteLine("Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }
    }
}
