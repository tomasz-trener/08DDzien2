using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace P03DostepDoPlikow
{
    class Program
    {
        static void Main(string[] args)
        {
            // string sciezka = "c:\\nane\\tekst.txt";
            string sciezka = @"c:\dane\tekst.txt";
            Console.WriteLine(sciezka);

            string zawartosc = File.ReadAllText(sciezka);
          
         //   Console.WriteLine(zawartosc);

            WebClient wc = new WebClient();
            string zawartoscHTML = wc.DownloadString(@"http:\\www.wp.pl");

            Console.WriteLine(zawartoscHTML);

            File.WriteAllText(@"c:\dane\tekst2.txt", "ala ma kota");

           string[] wiersze= File.ReadAllLines(sciezka);

            Console.ReadKey();
        }
    }
}
