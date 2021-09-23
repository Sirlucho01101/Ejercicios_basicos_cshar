using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_37
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para mostrar los multiplos de 5 con limite en 100");

            for (int i = 0; i <= 100; i += 5)
            {
                Console.WriteLine(i);

            }
            Console.WriteLine("Por favor pulse la tecla Intro para finalizar");
            Console.ReadLine();
        }
    }
}
