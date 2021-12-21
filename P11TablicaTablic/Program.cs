using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P11TablicaTablic
{
    class Program
    {
        static void Main(string[] args)
        {
            string sciezka = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";

            WebClient wc = new WebClient();
            string dane = wc.DownloadString(sciezka);

            string[] wiersze =
                dane.Split(new string[1] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            int liczbaWierszy = wiersze.Length;
            int liczbaKolumn = wiersze[0].Split(';').Length;

            string[][] tab = new string[liczbaWierszy-1][];

            for (int i = 1; i < liczbaWierszy; i++)
                tab[i - 1] = wiersze[i].Split(';');

            //for (int i = 0; i < tab.Length; i++)
            //{
            //    for (int j = 0; j < tab[0].Length; j++)
            //        Console.Write(tab[i][j] + " ");
            //    Console.WriteLine();
            //}

            //foreach (var w in tab)
            //{
            //    foreach (var k in w)
            //        Console.Write(k + " ");
            //    Console.WriteLine();
            //}

            foreach (var w in tab)
                Console.WriteLine(string.Join(" ",w));
                      
            Console.ReadKey();
        }
    }
}
