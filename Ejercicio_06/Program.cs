using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            double value;
            double num01;
            double num02;
            double num03;

            Console.WriteLine("Programa para calcular el 30%, 60% y 90% de un valor ingresado");
            Console.WriteLine("Digite el valor de el cual desea saber los porcentajes anteriormente mencionados: ");
            value = Int32.Parse(Console.ReadLine());
            num01 = value * 0.3;
            num02 = value * 0.6;
            num03 = value * 0.9;
            Console.WriteLine("El 30% de " + value + " es " + num01 + ", el 60% es " + num02 + " y el 90% es " + num03);
            Console.WriteLine("Por favor pulse la tecla Intro para finalizar");
            Console.ReadLine();
        }
    }
}
