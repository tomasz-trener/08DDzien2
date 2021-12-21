using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02ZadanieListy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proszę o podanie dowolengo zdania");
            string zdanie = Console.ReadLine().ToLower();

            string[] tab = zdanie.Split(' ');

            List<string> znalezione = new List<string>();

            for (int i = 0; i < tab.Length; i++)
                if (tab[i].Contains("a"))
                    znalezione.Add(tab[i]);

            foreach (var x in znalezione)
                Console.WriteLine(x);

            Console.ReadKey();


            // kiedy lepiej stosować tablice:
            //1 tablice sa szybsze niż listy 
            //2 kiedy chcemy dać do zrzumienia poprzez nasz kod, że ta kolekcja ma niezmienną liczebność
        }
    }
}
