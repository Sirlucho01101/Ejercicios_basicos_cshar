using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
    class Program
    {
        static void Main(string[] args)
        {
            int accountant = 201;

            Console.WriteLine("Programa para contar los numeros impares de 201 a 499 (el 200 se puede remplazar)");
            Console.WriteLine("NOTA: Recuerde que los pares solo seran contados hasta el valor anterior que sea impar");
            Console.WriteLine("Digie la tecla intro paara iniciar el conteo:");
            Console.ReadLine();

            for (accountant = 201; accountant <= 499;)
            {
                Console.WriteLine(accountant);
                accountant = accountant + 2;
            }
            Console.WriteLine("Por favor pulse la tecla Intro para finalizar");
            Console.ReadLine();
        }
    }
}
