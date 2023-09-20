using System;

namespace D
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, posPar = 0,posImp = 0;
            int maxPar = 0, minImp = 0;
            bool par = false, impar = false;

            for(int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());
                if(n % 2 == 0)
                {
                    if(!par){
                        maxPar = n;
                        par = true;
                        posPar = x + 1;
                    }
                    else if(n > maxPar){
                        maxPar = n;
                        par = true;
                        posPar = x + 1;
                    }
                }
                else{
                    if(!impar){
                        minImp = n;
                        impar = true;
                        posImp = x + 1;
                    }
                    else if(n < minImp){
                        minImp = n;
                        impar = true;
                        posImp = x + 1;
                    }
                }
            }
            Console.WriteLine("El máximo par es: " + maxPar + " y su posición fue: " + posPar);
            Console.WriteLine("El mínimo impar es: " + minImp + " y su posición fue: " + posImp);
            Console.WriteLine("Fin del programa");
        }
    }
}
