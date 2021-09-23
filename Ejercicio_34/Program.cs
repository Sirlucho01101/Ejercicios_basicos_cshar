using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    class Program
    {
        static void Main(string[] args)
        {
            int height, total = 0;
            double average;

            Console.WriteLine("Programa para determinar el promedio de estatura en un grupo de 18 estudiantes");

            for (int i = 1; i <= 18; i++)
            {
                Console.WriteLine("Digite la estatura del estudiante #" + i + " en centimetros");
                height = Int32.Parse(Console.ReadLine());
                total = total + height;
            }
            average = total / 18;

            if (average <= 140)
            {
                Console.WriteLine("La estatura promedio de el grupo de estudiantes es " + average + "cm");
                Console.WriteLine("Estudiantes muy bajos");
            }
            else if (average <= 170)
            {
                Console.WriteLine("La estatura promedio de el grupo de estudiantes es " + average + "cm");
                Console.WriteLine("Estudiantes de estatura normal");
            }
            else
            {
                Console.WriteLine("La estatura promedio de el grupo de estudiantes es " + average + "cm");
                Console.WriteLine("Estudiantes muy altos");
            }
            Console.WriteLine("Por favor pulse la tecla Intro para finalizar");
            Console.ReadLine();
        }
    }
}
