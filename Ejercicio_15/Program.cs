using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            double value;
            double division;

            
            Console.WriteLine("Programa para determinar si la mitad de un número es mayor o menor que 100");
            Console.WriteLine("Digite un valor: ");
            value = Int32.Parse(Console.ReadLine());
            division = (value / 2);

            if (division >= 100)
            {
                Console.WriteLine("La mitad de " + value + " es " + division + " y esto es mayor o igual a 100");
            }
            else
            {
                Console.WriteLine("La mitad de " + value + " es " + division + " y esto es menor que 100");
            }

            Console.WriteLine("Por favor pulse la tecla Intro para finalizar");
            Console.ReadLine();
        }
    }
}
