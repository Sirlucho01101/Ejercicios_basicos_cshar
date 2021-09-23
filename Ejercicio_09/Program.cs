using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_09
{
    class Program
    {
        static void Main(string[] args)
        {
            string product_reference;
            double unit;
            double price;
            double total;

            Console.WriteLine("Programa para calcular lo que debe pagar un cliente en una tienda");
            Console.WriteLine("Digite la referencia del producto:");
            product_reference = (Console.ReadLine());
            Console.WriteLine("Digite las unidades del producto:");
            unit = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite el precio del producto (no incluir el iva): ");
            price = double.Parse(Console.ReadLine());
            
            double sum;
            sum = unit * price;
            total = sum + (sum * 0.16);
            Console.WriteLine("El total a pagar es: " + total);
            Console.WriteLine("Por favor pulse la tecla Intro para finalizar");
            Console.ReadLine();
        }
    }
}
