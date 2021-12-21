using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10TabliceTablic
{
    class Program
    {
        static void Main(string[] args)
        {
            // tablice postrzępione (tablice tablic), ang. jagged array

            string[] tab = new string[3];

            string[][] tab2 = new string[3][];

            tab2[0] = new string[2];
            tab2[1] = new string[2];
            tab2[1] = new string[2];

            tab2[0][0] = "a";
            tab2[0][1] = "b";
            tab2[1][0] = "c";
            tab2[1][1] = "d";
            tab2[2][0] = "e";
            tab2[2][1] = "f";

            int dlugosc = tab2.Length; //3
            int szerokosc = tab2[0].Length; //2;

            int calkowitaLiczbaEl = dlugosc * szerokosc;



        }
    }
}
