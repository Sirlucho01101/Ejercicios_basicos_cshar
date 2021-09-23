using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_23
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            double heigth;
            int weigth;

            Console.WriteLine("Programa para saber si un deportista puede entrar al equipo de baloncesto de Bogota");
            Console.WriteLine("Digite su edad: ");
            age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("digiye su altura: ");
            heigth = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite su peso: ");
            weigth = Int32.Parse(Console.ReadLine());

            if (age <= 18)
            {
                if (heigth >= 180)
                {
                    if (weigth <= 80)
                    {
                        Console.WriteLine("El aspirante es aseptado devido a que cumple con los requerimientos");
                    }
                    
                }
            }
            else
            {
                Console.WriteLine("El aspirante es rechazado devido a que no cumple con los requerimientos");
            }

            Console.WriteLine("Por favor pulse la tecla Intro para finalizar");
            Console.ReadLine();
        }
    }
}
