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
            Console.WriteLine("Numero iniciales:  " + num);
            
            while(num>9){
            
                int producto = 1;
                while(num != 0){

                    int unidades = num % 10;
                    producto *= unidades;
                    num = (num - unidades) / 10;

                }

                repeticiones++;
                Console.WriteLine("Producto" + repeticiones + " numero es: " + producto);
                num = producto;
            
            }

            Console.WriteLine("La persistencia es: " + repeticiones);
            Console.WriteLine();

          }
        }

    }
}
