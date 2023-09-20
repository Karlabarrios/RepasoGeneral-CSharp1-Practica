using System;

namespace E
{
    class Program
    {
        static void Main(string[] args)
        {
            /*No funciona si se agregan números del menor al mayor porque no puede encontrar al segundo menor. AYUDAAAAA*/
            int n;
            Console.WriteLine("Ingrese un número:");
            n = int.Parse(Console.ReadLine());
            int me = n, meDos = me;
            while(n != 0){
                if(n < me){
                    meDos = me;
                    me = n;
                }
                else if(n < meDos)
                    meDos = n;
                
                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("El número menor es: " + me);
            Console.WriteLine("El segundo número menor es: " + meDos);
        }
    }
}
