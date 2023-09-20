using System;

namespace F
{
    class Program
    {
        static int haceAlgo2(ref int numero, ref int numero2)
        {
            int res;
            numero = numero * 2;
            numero2 = numero2 * 3;
            
            res = numero * numero2;
            return res;
        }

        static void Main()
        {
            Console.Write("Ingrese un nro: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Ingrese otro nro: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("El resultado es: " + haceAlgo2(ref a, ref b));
            Console.WriteLine("El resultado es: " + haceAlgo2(ref a, ref b));
            Console.WriteLine("El resultado es: " + haceAlgo2(ref a, ref b));
        }

    }
}
