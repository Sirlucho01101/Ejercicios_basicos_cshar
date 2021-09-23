using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_38
{
    class Program
    {
        static void Main(string[] args)
        {
            float note, average = 0, total;

            Console.WriteLine("Programa para determinar si un estudiante aprueba o no la materia de programacion de software");
            Console.WriteLine("(el resultado saldra de calcular 15 notas)");
            Console.WriteLine("Nota: Recuerde que a la hora de escribir las notas en decimal, utilice la coma en vez del punto");


            for (int i = 1; i <= 15; i++)
            {
                Console.WriteLine("Digite la nota #" + i);
                note = float.Parse(Console.ReadLine());

                average = average + note;
            }
            total = average / 15;
            Console.WriteLine("La nota definitiva es: " + total);

            if (total >= 4.0)
            {
                Console.WriteLine("El estudiante aprobo la materia");
            }
            else
            {
                Console.WriteLine("El estudiante reprobo la materia");
            }
            Console.WriteLine("Por favor pulse la tecla Intro para finalizar");
            Console.ReadLine();
        }
    }
}
