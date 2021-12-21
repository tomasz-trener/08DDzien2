using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P13WlasneKlasy
{
    class Program
    {
        static void Main(string[] args)
        {
            //kod wykonawczy 

            WebClient wc = new WebClient();
            //  WebClient wc2 = new WebClient();

            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder("ala");

            Kalukator k = new Kalukator();
          
            int a = 5;
            //int w= k.Dodaj(a, 5);

            int w2 = k.Przemnoz(2, 3);
            Console.WriteLine(w2);



            string n = k.PodajNazwe();

            Console.ReadKey();
        }
    }
}
