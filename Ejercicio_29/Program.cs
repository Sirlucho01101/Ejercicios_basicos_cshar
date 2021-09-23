using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    class Program
    {
        static void Main(string[] args)
        {
            int accountant = 0;

            Console.WriteLine("Programa para contar los numeros pares de 0 a 200");
            Console.WriteLine("NOTA: Recuerde que los impares solo seran contados hasta el valor anterior que sea par");
            Console.WriteLine("Digie la tecla intro paara iniciar el conteo:");
            Console.ReadLine();

            for (accountant = 0; accountant <= 200;)
            {
                Console.WriteLine(accountant);
                accountant = accountant + 2;
            }
            Console.WriteLine("Por favor pulse la tecla Intro para finalizar");
            Console.ReadLine();
        }
    }
}
