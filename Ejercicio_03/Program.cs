using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            double speed;
            double time;
            double distance;

            Console.WriteLine("Programa para calcular la distancia recorrida en un movimiento rectilíneo");
            Console.WriteLine("Digite la velocidad en km/h: ");
            speed = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite el tiempo: ");
            time = double.Parse(Console.ReadLine());
            distance = speed * time;
            Console.WriteLine("la distancia que se recorrio fue: " + distance + " metros");
            Console.WriteLine("Por favor pulse la tecla Intro para finalizar");
            Console.ReadLine();
        }
    }
}
