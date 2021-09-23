using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int monday;
            int tuesday;
            int wednesday;
            int thursday;
            int friday;
            int saturday;
            int sunday;
            int total;
            int average;

            Console.WriteLine("Programa para calcular la temperatura de la semana:");
            Console.WriteLine("Digite la temperatura del lunes: ");
            monday = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite la temperatura del martes: ");
            tuesday = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite la temperatura del miercoles: ");
            wednesday = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite la temperatura del jueves: ");
            thursday = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite la temperatura del viernes: ");
            friday = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite la temperatura del sabado: ");
            saturday = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite la temperatura del domingo: ");
            sunday = Int32.Parse(Console.ReadLine());

            total = monday + tuesday + wednesday + thursday + friday + saturday + sunday;
            average = total / 7;

            if (average > 35)
            {
                Console.WriteLine("El clima total de la semana fue: " + average);
                Console.WriteLine("Que semana tan calurosa: ");
            }
            else if (average > 15)
            {
                Console.WriteLine("El clima total de la semana fue: " + average);
                Console.WriteLine("Que clima tan delicioso");
            }
            else
            {
                Console.WriteLine("El clima total de la semana fue: " + average);
                Console.WriteLine("Que semana tan fria");
            }
            Console.WriteLine("Por favor pulse la tecla Intro para finalizar");
            Console.ReadLine();
        }
    }
}
