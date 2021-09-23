using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int degree;

            Console.WriteLine("Programa para saber si un estudiante del Enrique Olaya Herrera requiere refrigerio.");
            Console.WriteLine("Por disposición de la Secretaria de Educación requieren refrigerio los estudiantes de grado sexto hacia abajo.");
            Console.WriteLine("Digite el nombre del estudiante: ");
            name = (Console.ReadLine());
            Console.WriteLine("Digite el grado del estudiante en numero: ");
            degree = Int32.Parse(Console.ReadLine());

            if (degree <= 6)
            {
                Console.WriteLine("El esetudiante " + name + " del grado " + degree + " requiere refrigerio");
            }
            else
            {
                Console.WriteLine("El estudiante " + name + " del grado " + degree + " no requiere refrigerio");
            }

            Console.WriteLine("Por favor pulse la tecla Intro para finalizar");
            Console.ReadLine();
        }
    }
}
