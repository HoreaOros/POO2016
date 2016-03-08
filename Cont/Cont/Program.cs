using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cont
{
    class Program
    {
        static void Main(string[] args)
        {
            ContBancar c1 = new ContBancar("John");

            c1.Depune(-100);
            Console.WriteLine(c1.Sold);

            c1.Depune(100);
            Console.WriteLine(c1.Sold);

            c1.Retrage(50);
            Console.WriteLine(c1.Sold);

            c1.Retrage(150);
            Console.WriteLine(c1.Sold);
        }
    }
}
