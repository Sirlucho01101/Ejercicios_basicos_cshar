using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_33
{
    class Program
    {
        static void Main(string[] args)
        {
            int age, total = 0;
            double average;

            Console.WriteLine("Programa para determinar el promedio de edades en un grupo de 15 estudiantes");

            for (int i = 1; i <= 15; i++)
            {
                Console.WriteLine("Digite la edad del estudiante #" + i);
                age = Int32.Parse(Console.ReadLine());
                total = total + age;
            }
            average = total / 15;
            Console.WriteLine("El promedio de edades del grupo es " + average + " años");
            Console.WriteLine("Por favor pulse la tecla Intro para finalizar");
            Console.ReadLine();
        }
    }
}
