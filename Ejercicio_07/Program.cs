using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int side;
            int area;

            Console.WriteLine("Programa para calcular el area de un cuadrado");
            Console.WriteLine("Digite la medida de uno de los lados del cuadrado en metros: ");
            side = Int32.Parse(Console.ReadLine());
            area = side * side;
            Console.WriteLine("el area del cuadrado es: " + area + " metros");
            Console.WriteLine("Por favor pulse la tecla Intro para finalizar");
            Console.ReadLine();
        }
    }
}
