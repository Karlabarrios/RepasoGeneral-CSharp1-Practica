using System;

namespace D._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x = 0, pos = 1, max = 0;
            Console.WriteLine("Ingrese un número: ");
            n = int.Parse(Console.ReadLine());
            while(n != 0){
                if(x == 0){
                    max = n;
                    pos = 1;
                }
                else if(n > max){
                    max = n;
                    pos = x + 1;
                }

                x++;
                Console.WriteLine("Ingrese un número: ");
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("El número más grande es: " + max);
            Console.WriteLine("Encontrado en la posición: " + pos);
        }
    }
}
