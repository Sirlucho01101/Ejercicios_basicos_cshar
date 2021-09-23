using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            double unit;
            double price;
            double pay;

            Console.WriteLine("Programa para determinar el precio total a pagar de una compra realizada");
            Console.WriteLine("Digite las unidades del producto: ");
            unit = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite el precio individual del producto: ");
            price = double.Parse(Console.ReadLine());

            double sum;
            sum = unit * price;

            if (sum < 20000)
            {
                pay = sum - (sum * 0.15);
                Console.WriteLine("El valor total a pagar incluyendo el 15% de descuento por compra menor a 20000 es: " + pay);
            }
            else
            {
                pay = sum - (sum * 0.35);
                Console.WriteLine("El valor total a pagar incluyendo el 35% de descuento por compra mayor o igual a 20000 es: " + pay);
            }

            Console.WriteLine("Por favor pulse la tecla Intro para finalizar");
            Console.ReadLine();
        }
    }
}
