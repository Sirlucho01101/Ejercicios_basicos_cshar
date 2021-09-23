using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_40
{
    class Program
    {
        static void Main(string[] args)
        {
            int value, accountant = 0, sum = 0;

            Console.WriteLine("Programa para mostrar los numeros naturales desde 0 hasta el el numero que el usuario determine");
            Console.WriteLine("Digite un numero natural como limite:");
            value = Int32.Parse(Console.ReadLine());
            
            while (accountant <= value)
            {
                sum = value * (value + 1) / 2;
                accountant++;
            }
            Console.WriteLine("El total de la suma es: " + sum);
            Console.WriteLine("Por favor pulse la tecla Intro para finalizar");
            Console.ReadLine();
        }
    }
}
