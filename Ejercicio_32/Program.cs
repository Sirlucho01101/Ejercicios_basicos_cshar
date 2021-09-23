using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_32
{
    class Program
    {
        static void Main(string[] args)
        {
            string sex;
            int man, woman, sum = 0, sum2 = 0;

            Console.WriteLine("Programa que permita determinar cuantos hombres, mujeres y otros hay en un curso de 25 estudiantes");

            for (int i = 1; i <= 25; i ++)
            {
                Console.WriteLine("Digite el sexo de la persona #" + i);
                sex = Console.ReadLine();

                if (sex == "hombre")
                {
                    man = 1;
                    sum += man;
                }
                else if (sex == "mujer")
                {
                    woman = 1;
                    sum2 += woman;
                }
                else
                {
                    Console.WriteLine("Digite un sexo valido");
                    i = i - 1;
                }
            }
            Console.WriteLine("La cantidad de hombres es " + sum + " y la cantidad de mujeres es " + sum2);
            Console.WriteLine("Por favor pulse la tecla Intro para finalizar");
            Console.ReadLine();
        }
    }
}
