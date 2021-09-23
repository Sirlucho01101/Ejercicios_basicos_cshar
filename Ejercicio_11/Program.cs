using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int year_birth;
            int age;

            Console.WriteLine("Programa para calcular la edad de una persona y determinar si es mayor o menor de edad");
            Console.WriteLine("Digite su año de nacimiento:");
            year_birth = Int32.Parse(Console.ReadLine());
            age = DateTime.Today.Year - year_birth;
            Console.WriteLine("Su edad es: " + age);

            if (age >= 18)
            {
                Console.WriteLine("Usted es mayor de edad");
            }
            else
            {
                Console.WriteLine("Usted es menor de edad");
            }

            Console.WriteLine("Por favor pulse la tecla Intro para finalizar");
            Console.ReadLine();
        }
    }
}
