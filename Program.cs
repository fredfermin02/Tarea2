using System;

namespace Programas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Introduzca un número: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("El primer digito de ese numero es: " + num);

            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para finalizar...");
            Console.ReadKey();

        }

    }
}