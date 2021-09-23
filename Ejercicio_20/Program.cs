using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;

            Console.WriteLine("Programa para eterminar si un numero es par o impar");
            Console.WriteLine("Digite un valor: ");
            value = Int32.Parse(Console.ReadLine());

            if (value %2 == 0)
            {
                Console.WriteLine("El valor " + value + " es par");
            }
            else
            {
                Console.WriteLine("El valor " + value + " es impar");
            }

            Console.WriteLine("Por favor pulse la tecla Intro para finalizar");
            Console.ReadLine();
        }
    }
}
