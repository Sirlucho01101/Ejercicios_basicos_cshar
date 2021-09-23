using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            float num01;
            float num02;
            float total;

            Console.WriteLine("Programa para restar 2 numeros si son iguales y si son diferentes sumarlos");
            Console.WriteLine("Nota: Recuerde que si va a escribir numeros decimales utilice la coma en vez del punto");
            Console.WriteLine("Digite el primer valor: ");
            num01 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite el segundo valor: ");
            num02 = float.Parse(Console.ReadLine());

            if (num01 == num02)
            {   
                total = num01 - num02;
                Console.WriteLine("Ambos digitos son iguales, con lo cual se restan y el resultado es " + total);
            }
            else
            {
                total = num01 + num02;
                Console.WriteLine("Ambos digitos son diferentes con lo cual se suman y el resultado es " + total);
            }

            Console.WriteLine("Por favor pulse la tecla Intro para finalizar");
            Console.ReadLine();
        }
    }
}
