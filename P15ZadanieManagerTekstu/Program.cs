using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P15ZadanieManagerTekstu
{
    class Program
    {
        static void Main(string[] args)
        {
            string zdanie = "ala ma kota i ma psaa";

            ManagerTekstu mt = new ManagerTekstu();
            string[] wyniki = mt.ZnajdzNajdluzszyWyraz(zdanie);

            foreach (var w in wyniki)
                Console.WriteLine(w);

            Console.ReadKey();
        }
    }
}
