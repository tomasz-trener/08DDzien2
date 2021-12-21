using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08TabliceWielowymiarowe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] tabDwuWymiarowa = new string[2, 3];

            string[,,] tabTrzyWymiarowa = new string[2, 3, 4];

            tabTrzyWymiarowa[1, 2, 0] = "a";

            //statystyka: 90% tab-jednoWym, 9% - tab-dwyWum, 1% - tab-3-Wym
        }
    }
}
