 using System;

namespace A
{
    class Program
    {
        static void Main(string[] args)
        {
            int e, nc = 0, mne = 0, mce = 0;
            Console.WriteLine("Ingrese el peso de la encomienda: ");
            e = int.Parse(Console.ReadLine());
            while(e > 0){
                int acu = 0;
                int ne = 0;

                while((e + acu <= 200) && e > 0){
                    acu += e;
                    ne++;
                    Console.WriteLine("Ingrese el peso de la encomienda: ");
                    e = int.Parse(Console.ReadLine());
                }
                nc++;
                Console.WriteLine("El camión nro: " + nc + " pesa: " + acu);

                if(ne > mne){
                    mne = ne;
                    mce = nc;
                }
            }
            Console.WriteLine("El nro de camión con más encomiendas es: " + mce);
            Console.WriteLine("Se cargaron: " + nc + " camiones");
        }
    }
}
