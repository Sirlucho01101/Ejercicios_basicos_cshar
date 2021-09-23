using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_39
{
    class Program
    {
        static void Main(string[] args)
        {
            int b, e, total = 1, count = 0;

            Console.WriteLine("Programa que calcule la potencia donde el usuario ingresa el valor de la base y de el exponente");
            Console.WriteLine("Digite el valor de la base:");
            b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite el valor de el exponente:");
            e = Int32.Parse(Console.ReadLine());

            while (count < e)
            {
                total = total * b;
                count++;
            }
            Console.WriteLine("el resultado es: " + total);
            Console.WriteLine("Por favor pulse la tecla Intro para finalizar");
            Console.ReadLine();
        }
    }
}
