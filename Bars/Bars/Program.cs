using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bars
{
    // Clasa principala a aplicatiei care contine metoda Main
    // Punctul de intrare in program.
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Metoda Main instantieaza clasele create in program
            si testeaza proprietatile acestor clase;
            */
            HorzBar h = new HorzBar(4);
            Console.WriteLine("Lugimea barei orizontale este: {0}", h.Length);

            VertBar v = new VertBar(3);
            Console.WriteLine("Inaltimea barei verticale este: {0}", v.Height);

            Frame f = new Frame(4, 2);
            Console.WriteLine("Latimea frame-ului este: {0}", f.Width);
            Console.WriteLine("Inaltimea frame-ului este: {0}", f.Height);

            Ladder ladd = new Ladder(2, 2, 1);

            
        }
    }
}
