using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P06ZadaniePogoda
{
    class Program
    {
        static void Main(string[] args)
        {
            const string adresUrl = "https://www.google.com/search?q=pogoda+";
            const char znak = '°';
            const string znakKoncowy = ">";

            while (true)
            {
                Console.WriteLine("podaj miasto");
                string miasto = Console.ReadLine();     

                WebClient wc = new WebClient();
                string dane = wc.DownloadString(adresUrl + miasto);
                // File.WriteAllText(@"c:\dane\pogoda.html", dane);

                int indx = dane.IndexOf(znak);
                int aktualnaPoz = indx - 1;
                
                while (dane.Substring(aktualnaPoz,1) != znakKoncowy)
                    aktualnaPoz--;
                //while (dane[aktualnaPoz] != znakKoncowy)
                //    aktualnaPoz--;

                string wynik = dane.Substring(aktualnaPoz + 1, indx - aktualnaPoz + 1);
                Console.WriteLine(wynik);
            }
            
        }
    }
}
