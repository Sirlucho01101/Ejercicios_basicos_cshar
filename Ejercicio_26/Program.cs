using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_26
{
    class Program
    {
        static void Main(string[] args)
        {
            double value;
            int menu;

            Console.WriteLine("Programa para determinar si un numero es positivo o negativo o si es par o impar dependiendo de la eleccion");
            Console.WriteLine("Digite un valor: ");
            value = double.Parse(Console.ReadLine());
            Console.WriteLine("Seleccione entre el siguiente menu: ");
            Console.WriteLine("para saber si el valor es positivo o negativo pulse 1: ");
            Console.WriteLine("Para saber si el valor es par o impar pulse 2: ");
            menu = Int32.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1: if (value >= 0)
                    {
                        Console.WriteLine("El valor " + + value + " es positivo");
                    }
                    else
                    {
                        Console.WriteLine("El valor " + value + " es negativo");
                    } break;

                case 2: if (value %2 == 0)
                    {
                        Console.WriteLine("El valor " + value + " es par");
                    }
                    else
                    {
                        Console.WriteLine("El valor " + value + " es impar");
                    } break;
            }

            Console.WriteLine("Por favor pulse la tecla Intro para finalizar");
            Console.ReadLine();
        }
    }
}
