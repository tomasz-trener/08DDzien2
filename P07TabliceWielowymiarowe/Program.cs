using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07TabliceWielowymiarowe
{
    class Program
    {
        static void Main(string[] args)
        {
            // czy 3x6 czy 6x3? 

            string[] tabJednoWym = new string[3];

            string[,] tabDwuWym = new string[2, 3];

            int dlugWym0 = tabDwuWym.GetLength(0); //2
            int dlugWym1 = tabDwuWym.GetLength(1); //3

            int dlugTab = tabDwuWym.Length; // 6 = 2*3

            tabDwuWym[0, 0] = "a";
            tabDwuWym[0, 1] = "b";
            tabDwuWym[0, 2] = "c";
            tabDwuWym[1, 0] = "d";
            tabDwuWym[1, 1] = "e";
            tabDwuWym[1, 2] = "f";

            for (int i = 0; i < dlugWym0; i++)
            {
                for (int j = 0; j < dlugWym1; j++)
                    Console.Write(tabDwuWym[i, j] + " ");
                Console.WriteLine();
            }

            Console.WriteLine("----------");

            for (int i = 0; i < dlugWym1; i++)
            {
                for (int j = 0; j < dlugWym0; j++)
                    Console.Write(tabDwuWym[j, i] + " ");
                Console.WriteLine();
            }


            Console.ReadKey();

        }
    }
}
