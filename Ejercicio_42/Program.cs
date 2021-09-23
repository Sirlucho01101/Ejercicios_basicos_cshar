using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, num, count = 0, cube, quarter, fifth;

            Console.WriteLine("Programa para calcular el cubo, la cuarta y la quinta de los numeros ingresados por el usuario");
            Console.WriteLine("Digite la cantidad de numeros a calcular:");
            n = Int32.Parse(Console.ReadLine());

            while (count < n)
            {
                Console.WriteLine("Digite un numero:");
                num = Int32.Parse(Console.ReadLine());

                cube = num * num * num;
                quarter = num * num * num * num;
                fifth = num * num * num * num * num;
                count++;

                Console.WriteLine(num + " al cubo es igual a " + cube);
                Console.WriteLine(num + " a la cuarta es igual a " + quarter);
                Console.WriteLine(num + " a la quinta es igual a " + fifth);
            }
            Console.WriteLine("Por favor pulse la tecla Intro para finalizar");
            Console.ReadLine();
        }
    }
}
