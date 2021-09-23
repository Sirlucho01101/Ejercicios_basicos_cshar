using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_18
{
    class Program
    {
        static void Main(string[] args)
        {
            double unit;
            double price;
            double pay;

            Console.WriteLine("Programa para determinar el precio total de una compra realizada");
            Console.WriteLine("Digite laas unidades del producto: ");
            unit = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite el precio del producto por unidad: ");
            price = double.Parse(Console.ReadLine());

            double sum;
            sum = unit * price;

            if (sum > 100000)
            {
                pay = sum - (sum * 0.20);
                Console.WriteLine("El valor total de su compra incluyendo el 20% de descuento por ser mayor a 100000 es: " + + pay);
            }
            else
            {
                Console.WriteLine("El valor total de su compra es: " + sum);
            }

            Console.WriteLine("Por favor pulse la tecla Intro para finalizar");
            Console.ReadLine();
        }
    }
}
