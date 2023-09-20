using System;

namespace B
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, c = 0;
            Console.WriteLine("Ingrese un número");
            n = int.Parse(Console.ReadLine());

            for(int x = 1; x <= n; x++)
            {
                if(n % x == 0)
                    c++;
            }
            if(c == 2)
                Console.WriteLine("El nro ingresado es número primo");
            else
                Console.WriteLine("El nro ingresado no es número primo");
        }
    }
}
