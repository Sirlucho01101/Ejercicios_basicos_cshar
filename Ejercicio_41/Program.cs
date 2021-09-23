using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_41
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, num, count = 0, higher = 0, less = 999999;

            Console.WriteLine("Programa para determinar cual numero es mayor y cual es menor dependiendo de lo que ingrese el usuario");
            Console.WriteLine("Digite la cantidad de numeros a analizar");
            n = Int32.Parse(Console.ReadLine());

            while (count < n)
            {
                Console.WriteLine("Digite un numero:");
                num = Int32.Parse(Console.ReadLine());
                count++;

                if (count == 0)
                {
                    higher = num;
                    less = num;
                }
                else if (count != 0)
                {
                    if (num < less)
                    {
                        less = num;
                    }
                    if (num > higher)
                    {
                        higher = num;
                    }
                }
            }
            Console.WriteLine("Numero mayor: " + higher);
            Console.WriteLine("Numero menor: " + less);
            Console.WriteLine("Por favor pulse la tecla Intro para finalizar");
            Console.ReadLine();
        }
    }
}
