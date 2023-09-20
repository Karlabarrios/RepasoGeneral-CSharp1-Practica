using System;

namespace B
{
    class Program
    {
        static void Main(string[] args)
        {
            int e, c = 0;
            Console.WriteLine("Se ingresará un grupo de edades");
            Console.WriteLine("Ingrese una edad");
            e = int.Parse(Console.ReadLine());

            while(e >= 18){
                c++;
                Console.WriteLine("Ingrese otra edad");
                e = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Hay " + c + " personas mayores de edad.");
        }
    }
}
