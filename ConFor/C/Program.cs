using System;

namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, maxn = 0, pos = 0;
            for(int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());
                if(x == 0)
                {
                    maxn = n;
                    pos = 1;
                }
                else if(n > maxn)
                {
                    maxn = n;
                    pos = x + 1;
                }
            }
            Console.WriteLine("El número mayor del grupo ingresado es: " + maxn);
            Console.WriteLine("Además, fue ingresado en la posición: " + pos);
        }
    }
}
