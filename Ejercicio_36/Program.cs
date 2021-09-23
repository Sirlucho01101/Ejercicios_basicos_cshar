using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_36
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, multiply = 0;

            Console.WriteLine("Programa para multiplicar un numero desde x*1 hasta x*10, cuando x es el valor ingresado por el usuario");

            Console.WriteLine("Digite el valor a multiplicar:");
            num = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                multiply = num * i;
                Console.WriteLine(num + "*" + i + "=" + multiply);
            }
            Console.WriteLine("Por favor pulse la tecla Intro para finalizar");
            Console.ReadLine();
        }
    }
}
