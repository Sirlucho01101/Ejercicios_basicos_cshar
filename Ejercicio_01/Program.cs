using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int num01;
            int num02;
            int solution;

            Console.WriteLine("Programa para calcular sumas");
            Console.WriteLine("Digite el primer valor: ");
            num01 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite el segundo valor: ");
            num02 = Int32.Parse(Console.ReadLine());
            solution = num01 + num02;
            Console.WriteLine("El resultado es: " + solution);
            Console.WriteLine("Por favor pulse la tecla Intro para finalizar");
            Console.ReadLine();
        }
    }
}
