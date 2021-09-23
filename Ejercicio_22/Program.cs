using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_22
{
    class Program
    {
        static void Main(string[] args)
        {
            double unit;
            double price;
            double pay;

            Console.WriteLine("Programa para determinar el precio total a pagar de una compra realizada en una super tienda");
            Console.WriteLine("Digite las unidades del producto: ");
            unit = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite el precio individual del producto: ");
            price = double.Parse(Console.ReadLine());

            double sum;
            sum = unit * price;

            if (sum <= 20000)
            {
                pay = sum - (sum * 0.10);
                Console.WriteLine("El precio sin el descuento es: " + sum);
                Console.WriteLine("El valor total a pagar incluyendo el 10% de descuento por compras entre 10000 y 20000 es: " + pay);
            }
            else if (sum <= 50000)
            {
                pay = sum - (sum * 0.30);
                Console.WriteLine("El precio sin el descuento es: " + sum);
                Console.WriteLine("El valor total a pagar incluyendo el 30% de descuento por compras entre 20000 y 50000 es: " + pay);
            }
            else
            {
                pay = sum - (sum * 0.50);
                Console.WriteLine("El precio sin el descuento es: " + sum);
                Console.WriteLine("El valor total a pagar incluyendo el 50% de descuento por compras mayores a 50000 es: " + pay);
            }

            Console.WriteLine("Por favor pulse la tecla Intro para finalizar");
            Console.ReadLine();
        }
    }
}
