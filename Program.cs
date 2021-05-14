using System;

namespace Programas
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Cuantos numeros desea ingresa");
          int CanNum = 0;
          CanNum = int.Parse(Console.ReadLine());
          for (int i = 0; i < CanNum; i++)
          {
            Console.WriteLine("Ingrese un numero para buscar su Persistencia multiplicativa");
            int num = 0;
            num = int.Parse(Console.ReadLine());
            int repeticiones = 0;
            Console.WriteLine("Numero iniciales: " + num);

          }
        }

    }
}
