using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P15ZadanieManagerTekstu
{
    class ManagerTekstu
    {

        private string[] podajWyrazy(int dlugosc, string zdanie)
        {
            string[] wyrazy = zdanie.Split(' ');

            List<string> znalezione = new List<string>();

            foreach (var w in wyrazy)
                if (w.Length == dlugosc)
                    znalezione.Add(w);

            return znalezione.ToArray();
        }

        public string[] ZnajdzNajdluzszyWyraz(string zdanie)
        {
            string[] wyrazy = zdanie.Split(' ');

            int najdluzszy = wyrazy[0].Length;
            int indeksNajdluzszego = 0;

            for (int i = 1; i < wyrazy.Length; i++)
            {
                if (wyrazy[i].Length > najdluzszy)
                {
                    najdluzszy = wyrazy[i].Length;
                    indeksNajdluzszego = i;
                }
            }
            string najdluzszyWyraz = wyrazy[indeksNajdluzszego];
            return podajWyrazy(najdluzszyWyraz.Length,zdanie);

        }
    }
}
