using System;

namespace D
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x = 1, pos = x;
            Console.WriteLine("Ingrese un número");
            n = int.Parse(Console.ReadLine());
            int max = n;

            while(n != 0){
                if(n > max){
                    max = n;
                    pos = x;
                }

                x++;
                Console.WriteLine("Ingrese otro número");
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("El número más grande es: " + max);
            Console.WriteLine("Encontrado en la posición: " + pos);
        }
    }
}
