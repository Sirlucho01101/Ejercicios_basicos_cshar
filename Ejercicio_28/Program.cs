using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para contar los numeros naturales de 0 a 1000");
            Console.WriteLine("Digie la tecla intro paara iniciar el conteo:");
            Console.ReadLine();

            for (int accountant = 0; accountant <= 1000;)
            {
                Console.WriteLine(accountant);
                accountant = accountant + 1;
            }
            Console.WriteLine("Por favor pulse la tecla Intro para finalizar");
            Console.ReadLine();
        }
    }
}
