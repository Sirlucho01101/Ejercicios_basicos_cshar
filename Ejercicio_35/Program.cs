using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para mostrar los multiplos de 3 con limite en 99");

            for (int i = 0; i <= 99; i+= 3)
            {
                Console.WriteLine(i);

            }
            Console.WriteLine("Por favor pulse la tecla Intro para finalizar");
            Console.ReadLine();
        }
    }
}
