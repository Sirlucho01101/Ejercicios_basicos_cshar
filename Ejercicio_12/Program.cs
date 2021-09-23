using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            double value;

            Console.WriteLine("Programa para calcular si un valor es positivo o negativo");
            Console.WriteLine("Digite el valor: ");
            value = double.Parse(Console.ReadLine());

            if (value >= 0)
            {
                Console.WriteLine("El valor es positivo");
            }
            else
            {
                Console.WriteLine("El valor es negativo");
            }

            Console.WriteLine("Por favor pulse la tecla Intro para finalizar");
            Console.ReadLine();
        }
    }
}
