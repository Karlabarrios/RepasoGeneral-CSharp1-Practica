using System;

namespace A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, c = 0;
            for(int x = 0; x < 6; x++)
            {
                Console.WriteLine("Ingrese un nro:")                ;
                n = int.Parse(Console.ReadLine());
                if(n > 0)
                    c++;
            }
            Console.WriteLine("La cantidad de números positivos es de: " + c);
        }
    }
}
