using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            float num01;
            float num02;

            Console.WriteLine("Programa para calcular si un valor es mayor, igual o menor que otro");
            Console.WriteLine("Digite el primer valor: ");
            num01 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite el segundo valor: ");
            num02 = float.Parse(Console.ReadLine());

            if (num01 > num02)
            {
                Console.WriteLine("El valor " + num01 + " es mayor que el valor " + num02);
            }
            else if (num01 == num02)
            {
                Console.WriteLine("El valor " + num01 + " es igual al valor " + num02);
            }
            else
            {
                Console.WriteLine("El valor " + num01 + " menor que el valor " + num02);
            }

            Console.WriteLine("Por favor pulse la tecla Intro para finalizar");
            Console.ReadLine();
        }
    }
}
