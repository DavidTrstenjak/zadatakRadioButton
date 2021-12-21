using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba1
{
    class KlasaC
    {
        int zbroj;
        int prosjek;
        
        public int Zbroj(int[] niz)
        {
            
            int zbroj = 0;
            for (int brojac = 0; brojac < niz.Length; brojac++)
            {
                zbroj += niz[brojac];
            }
            

            return zbroj;
        }

        public double Prosjek(int[] niz)
        {
            double zbroj = Zbroj(niz);
            double prosjek = zbroj / niz.Length;
            return prosjek;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int redniBroj = 1;
            int[] niz = new int[5];

            int zbroj;
            double prosjek;

            Console.WriteLine("Vježba 2 - klase i objekti\n");
            Console.WriteLine("Upiši 5 brojeva0");

            for (int brojac = 0; brojac < niz.Length; brojac++)
            {
                Console.Write(redniBroj + ". broj: ");
                niz[brojac] = Convert.ToInt32(Console.ReadLine());
                redniBroj++;
            }

            KlasaC objekt = new KlasaC();

            zbroj = objekt.Zbroj(niz);
            Console.WriteLine("Zbroj članova niza je: " + zbroj);
            prosjek = objekt.Prosjek(niz);
            Console.WriteLine("Prosjek članova je: " + prosjek);

            Console.ReadKey();
        }
    }

    
}
