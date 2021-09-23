using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int year_birth;
            int age;

            Console.WriteLine("Programa para calcular la edad de una parsona");
            Console.WriteLine("Digite su año de nacimiento: ");
            year_birth = int.Parse(Console.ReadLine());
            age = DateTime.Today.Year - year_birth;
            Console.WriteLine("Su edad es: " + age);
            Console.WriteLine("Por favor pulse la tecla Intro para finalizar");
            Console.ReadLine();
        }
    }
}
