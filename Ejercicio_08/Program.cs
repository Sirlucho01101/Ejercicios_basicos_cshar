using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int num01;
            int num02;
            int num03;
            int num04;
            int num05;
            int total;
            double average;

            Console.WriteLine("Programa para calcular el promedio de 5 valores ingresados");
            Console.WriteLine("Digite el primer valor: ");
            num01 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite el segundo valor: ");
            num02 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite el tercer valor: ");
            num03 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite el cuarto valor: ");
            num04 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite el quinto valor: ");
            num05 = Int32.Parse(Console.ReadLine());

            total = num01 + num02 + num03 + num04 + num05;
            average = total / 5;
            Console.WriteLine("El promedio de los valores digitados es: " + average);
            Console.WriteLine("Por favor pulse la tecla Intro para finalizar");
            Console.ReadLine();

        }
    }
}
