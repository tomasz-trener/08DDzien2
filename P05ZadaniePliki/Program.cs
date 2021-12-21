using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05ZadaniePliki
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ścieżkę do pliku");
            string sciezka = Console.ReadLine();
            string dane = File.ReadAllText(sciezka);
            string[] zdania = dane.Split('.');

            while (true)
            {
                Console.WriteLine("Podaj wyraz");
                string wyraz = Console.ReadLine();
                foreach (var z in zdania)
                    if (z.Contains(wyraz))
                        Console.WriteLine(z);
            }
            


        }
    }
}
