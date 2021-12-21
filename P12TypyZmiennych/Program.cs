using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P12TypyZmiennych
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            char b = 'x';
            string c = "napis";
            double d = 8.54;
            bool e = false;
            string f = "21-12-2021";
                       
            DateTime dt = new DateTime(2021, 12, 21);
           
            WebClient wc = new WebClient();

            StringBuilder sb = new StringBuilder();
            sb.Append("ala");
            sb.Append(" ma");
            sb.Append(" konta");
            string wynik = sb.ToString(); // "ala ma kota"

            DateTime dt2= dt.AddDays(10);
            
        }
    }
}
