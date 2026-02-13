namespace Opciones.Bloque2
{
    public class SistemaCalificacionesUNAH
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- Sistema de Calificaciones UNAH ---");
            Console.Write("Ingrese la nota (0-100): ");
            int nota = Convert.ToInt32(Console.ReadLine());
            if (nota < 0 || nota > 100)
            {
                Console.WriteLine("Nota fuera de rango.");
            }
            else
            {
                string letra, descripcion, estado;
                if (nota >= 90) { letra = "A"; descripcion = "Excelente"; estado = "Aprobado"; }
                else if (nota >= 80) { letra = "B"; descripcion = "Muy bueno"; estado = "Aprobado"; }
                else if (nota >= 70) { letra = "C"; descripcion = "Bueno"; estado = "Aprobado"; }
                else if (nota >= 60) { letra = "D"; descripcion = "Suficiente"; estado = "Aprobado"; }
                else { letra = "F"; descripcion = "Reprobado"; estado = "Reprobado"; }
                Console.WriteLine($"Letra: {letra}, Descripción: {descripcion}, Estado: {estado}");
            }
            Console.WriteLine("Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }
    }
}
