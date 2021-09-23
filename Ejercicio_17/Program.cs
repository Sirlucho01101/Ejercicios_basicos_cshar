using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            float student_code;
            string student_name;
            string subject_name;
            float note01;
            float note02;
            float note03;
            float sum;
            float final_note;

            Console.WriteLine("Programa para calcular si un estudiante aprueba o reprueba una materia");
            Console.WriteLine("Nota: Recuerde que a la hora de escribir las notas en decimal, utilice la coma en vez del punto");
            Console.WriteLine("Digite el codigo del estudiante:");
            student_code = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite el nombre del estudiante: ");
            student_name = (Console.ReadLine());
            Console.WriteLine("Digite el nombre de la materia: ");
            subject_name = (Console.ReadLine());
            Console.WriteLine("Digite la primera nota: ");
            note01 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la segunda nota: ");
            note02 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la tercer nota: ");
            note03 = float.Parse(Console.ReadLine());

            sum = note01 + note02 + note03;
            final_note = sum / 3;

            Console.WriteLine("Codigo del estudiante: " + student_code);
            Console.WriteLine("Nombre del estudiante: " + student_name);
            Console.WriteLine("Nombre de la materia: " + subject_name);
            
            if (final_note >= 4.0)
            {
                Console.WriteLine("Aprobo");
            }
            else
            {
                Console.WriteLine("Reprobo");
            }

            Console.WriteLine("Por favor pulse la tecla Intro para finalizar");
            Console.ReadLine();
        }
    }
}
