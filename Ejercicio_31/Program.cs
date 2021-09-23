using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
    class Program
    {
        static void Main(string[] args)
        {
            int age, mayor, sum = 0;

            Console.WriteLine("Programa para determinar cuantos estudiantes mayores de edad hay en un grupo de 20");

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("Digite la edad del estudiante #" + i);
                age = Int32.Parse(Console.ReadLine());

                if (age >= 18)
                {
                    mayor = 1;
                    sum += mayor;
                }
                else
                {
                    
                }
            }
            Console.WriteLine("El total de estudiantes mayores de edad es " + sum);
            Console.WriteLine("Por favor pulse la tecla Intro para finalizar");
            Console.ReadLine();
        }
    }
}
