using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_27
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu;
            string student_name;
            string subject_name;
            float note01;
            float note02;
            float note03;
            float sum;
            float final_note;
            int year_birth;
            int age;


            Console.WriteLine("Programa para determinar si un estudiante pasa o no la materia o para determinar la edad de una persona");
            Console.WriteLine("Seleccione entre el siguiente menu: ");
            Console.WriteLine("para saber si el estudiante pasa o no la materia pulse 1: ");
            Console.WriteLine("Para saber si la persona es mayor de edad o no pulse 2: ");
            menu = Int32.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1: Console.WriteLine("Nota: Recuerde que a la hora de escribir las notas en decimal, utilice la coma en vez del punto");
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

                    Console.WriteLine("Nombre del estudiante: " + student_name);
                    Console.WriteLine("Nombre de la materia: " + subject_name);

                    if (final_note >= 3.0)
                    {
                        Console.WriteLine("Aprovo con una nota de: " + final_note);
                    }
                    else
                    {
                        Console.WriteLine("reprovo con una nota de: " + final_note);
                    } break;

                case 2: Console.WriteLine("Digite su año de nacimiento:");
                    year_birth = Int32.Parse(Console.ReadLine());
                    age = DateTime.Today.Year - year_birth;
                    Console.WriteLine("Su edad es: " + age);

                    if (age >= 18)
                    {
                        Console.WriteLine("Es mayor de edad");
                    }
                    else
                    {
                        Console.WriteLine("Es menor de edad");
                    } break;
            }

            Console.WriteLine("Por favor pulse la tecla Intro para finalizar");
            Console.ReadLine();
        }
    }
}
