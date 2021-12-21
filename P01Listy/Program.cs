using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01Listy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string[] tabA; // zmienna , która na razie nie wskazuje na tablicę, więc nie mogę
            // na tablcy pracować bo tej tablict jeszcze tak naprawdę nie utowrzyłem.
            
            string[] tab = new string[n];

            List<string> listaA; // zmienna listaA, która wskazuje na null

            listaA = new List<string>(); // w tym momencie listaA zaczyna wskazywać 
            // na nową listę, posiadającą 0 elementów ale od tego będę mógł pracaować na tej liście

            List<string> lista = new List<string>();
            // zmienna "lista" wskazuje na listę posiadającą 0 elementów

            lista.Add("ala");
            lista.Add("ma");
            lista.Add("kota");

            string napis = lista[1]; // ma 
            lista[1] = "będzie miała";

            int dlugoscListy = lista.Count;

            lista.Add("psa");

            // lista.Insert(0, "mała");
            lista.Insert(3, "i ma");

            for (int i = 0; i < lista.Count; i++)
                Console.WriteLine(lista[i]);

            lista.RemoveAt(1);

            Console.ReadKey();

        }
    }
}
