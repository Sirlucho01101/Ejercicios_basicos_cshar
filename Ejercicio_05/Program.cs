using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            double porcent;

            Console.WriteLine("Programa para calcular el 20% de un valor ingresado");
            Console.WriteLine("Digite el valor de el cual desea saber el 20%: ");
            num = Int32.Parse(Console.ReadLine());

            porcent = num * 0.2;
            Console.WriteLine("el 20% de " + num + " es " + porcent);
            Console.WriteLine("Por favor pulse la tecla Intro para finalizar");
            Console.ReadLine();

        }
    }
}
