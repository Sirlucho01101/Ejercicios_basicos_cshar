using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            double minimum_salary;
            double worked_days;
            double total;

            Console.WriteLine("Programa para calcular el salario de un empleado");
            Console.WriteLine("Digite el salario minimo: ");
            minimum_salary = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite los dias trabajados: ");
            worked_days = Int32.Parse(Console.ReadLine());

            double sum;
            sum = minimum_salary * worked_days;
            total = sum - (sum * (0.1 + 0.15));
            Console.WriteLine("total: " + total);
            Console.WriteLine("Por favor pulse la tecla Intro para finalizar");
            Console.ReadLine();
        }
    }
}
