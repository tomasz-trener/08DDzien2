using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P04ZadanieZawodnicy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj kraj");
            string kraj = Console.ReadLine();
            
            string sciezka = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";

            WebClient wc = new WebClient();
            string dane = wc.DownloadString(sciezka);

            string[] wiersze = dane.Split('\n');

            List<string> imionaINazwiska = new List<string>();

            foreach (var w in wiersze)
            {
                string[] komorki = w.Split(';');
                if (komorki[4] == kraj)
                    imionaINazwiska.Add($"{komorki[2]} {komorki[3]}");
            }

            File.WriteAllLines($@"c:\dane\{kraj}.txt", imionaINazwiska);
        }
    }
}
