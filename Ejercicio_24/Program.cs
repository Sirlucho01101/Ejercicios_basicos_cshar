using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_24
{
    class Program
    {
        static void Main(string[] args)
        {
            string vocal;

            Console.WriteLine("Programa para determinar si una letra es una vocal o no");
            vocal = (Console.ReadLine());

            switch (vocal)
            {
                case "a": Console.WriteLine("La letra " + vocal + " es una vocal"); break;
                case "e": Console.WriteLine("La letra " + vocal + " es una vocal"); break;
                case "i": Console.WriteLine("La letra " + vocal + " es una vocal"); break;
                case "o": Console.WriteLine("La letra " + vocal + " es una vocal"); break;
                case "u": Console.WriteLine("La letra " + vocal + " es una vocal"); break;
                default: Console.WriteLine("La letra " + vocal + " no es una vocal"); break;
            }

            Console.WriteLine("Por favor pulse la tecla Intro para finalizar");
            Console.ReadLine();
        }
    }
}
