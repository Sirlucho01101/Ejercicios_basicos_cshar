using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_25
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance;
            double time;
            double speed;
            int formula;

            Console.WriteLine("Programa para calcular distancia, tiempo y velocidad dependiendo de la opcion seleccionada");
            Console.WriteLine("Digite un valor (1=distancia, 2=tiempo y 3=velocidad: ");
            formula = Int32.Parse(Console.ReadLine());

            switch (formula)
            {
                case 1: Console.WriteLine("Digite la velocidad en km/h: ");
                    speed = double.Parse(Console.ReadLine());
                    Console.WriteLine("DIgite el tiempo: ");
                    time = double.Parse(Console.ReadLine());
                    distance = speed * time;
                    Console.WriteLine("La distancia recorrida fue de " + distance + " km/h"); break;

                case 2: Console.WriteLine("Digite la distancia en km/h: ");
                    distance = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite la velocidad en km/h: ");
                    speed = double.Parse(Console.ReadLine());
                    time = distance / speed;
                    Console.WriteLine("EL tiempo fue de " + time + " horas"); break;

                case 3: Console.WriteLine("Digite la distancia en km/h: ");
                    distance = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite el tiempo: ");
                    time = double.Parse(Console.ReadLine());
                    speed = distance / time;
                    Console.WriteLine("La velocidad fue de " + speed + " km/h"); break;

                default: Console.WriteLine("No existe ninguna formula"); break;
            }
            Console.WriteLine("Por favor pulse la tecla Intro para finalizar");
            Console.ReadLine();
        }
    }
}
