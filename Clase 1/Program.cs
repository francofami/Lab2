using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio00
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int edad;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hola mundo");

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Write("\nIngrese su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Su nombre es: {0}", nombre);

            Console.Write("\nIngrese su edad: ");
            edad=int.Parse(Console.ReadLine());
            Console.WriteLine("Su edad es: {0}", edad);

            Console.ReadLine();


        }
    }
}
