using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int num01;
            int num02;
            int num03;
            int solution;

            Console.WriteLine("Programa para calcular multiplicaciones de 3 valores");
            Console.WriteLine("Digite el primer: ");
            num01 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite el segundo valor: ");
            num02 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite el tercer valor: ");
            num03 = Int32.Parse(Console.ReadLine());
            solution = num01 * num02 * num03;
            Console.WriteLine("el resultado es: " + solution);
            Console.WriteLine("Por favor pulse la tecla Intro para finalizar");
            Console.ReadLine();
        }
    }
}
