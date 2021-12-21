using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13WlasneKlasy
{
    class Kalukator
    {
        // kod deklaratywny

        // tutaj mozemy zdefiniowac 4 elementy 

        //1) pola -> cechy obiektu (właściwości)
        //2) właściwości --> to samo co pola
        //3) konstruktory -> określa sposób tworzenia obiektu
        //4) metody -> umiejętności obiektu 

        
        private int Dodaj(int a, int b)
        {
            //kod wykonawczy
            return a + b;
        }

        public int Przemnoz(int a,int b)
        {
            // return a * b;

            int wynik = 0;
            for (int i = 0; i < b; i++)
                wynik = Dodaj(wynik, a);

            return wynik;
        }

        public string PodajNazwe()
        {
            return "K1";
        }

        public char InnaMetoda()
        {
            return 'x';
        }

        public string[] InnaMetoda2()
        {
            string[] s = new string[2];
            return s;
        }

        public StringBuilder InnaMetoda3()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("a");
            return sb;
        }

        public void MetodaNicNieZwracajaca()
        {
            // ta metoda tylko coś robi
            Console.WriteLine("Hello");
        }

    }
}
