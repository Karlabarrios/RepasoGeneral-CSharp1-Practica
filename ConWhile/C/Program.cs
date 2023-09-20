using System;

namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, Me = 0, M = 0;
            Console.WriteLine("Ingrese un número");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro");
            B = int.Parse(Console.ReadLine());
            if(A > B){
                M = A;
                Me = B;
            }
            else{
                M = B;
                Me = A;
            }

            while(Me < M && Me != M -1){
                Me++;
                Console.WriteLine(Me);
            }
            Console.WriteLine("Fin del programa.");
        }
    }
}
