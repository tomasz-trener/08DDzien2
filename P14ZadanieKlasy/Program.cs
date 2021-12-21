using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14ZadanieKlasy
{
    class Program
    {
        static void Main(string[] args)
        {
            Kalkulator k = new Kalkulator();

            Console.WriteLine("Podaj równanie");
            string r = Console.ReadLine();

            try
            {
                double? w = k.Policz(r);
                Console.WriteLine(w);
            }
            catch (Exception ex)
            {
               // Console.WriteLine(ex.Message);
                Console.WriteLine("coś nie tak");
            }

            Console.ReadKey();
        }
    }
}
