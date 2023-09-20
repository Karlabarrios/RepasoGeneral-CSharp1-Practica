using System;

namespace E._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m2 = 0;
            bool b = false;
            Console.WriteLine("Ingrese un número:");
            n = int.Parse(Console.ReadLine());
            int m1 = n;

            while(n != 0){
                if(n < m1){
                    m2 = m1;
                    m1 = n;
                }
                else{
                    if(!b){
                        m2 = n;
                        b = true;
                    }
                    else if(n < m2)
                        m2 = n;
                }
                Console.WriteLine("Ingrese otro número:");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("El primer menor es: " + m1);
            Console.WriteLine("El segundo menor es: " + m2);
        }
    }
}
