using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Shape(1);
            Console.WriteLine(s);

            Shape t = new Shape(2, new Point(2.2, 3.4), new Point(1.2, 4.5));
            Console.WriteLine(t);

            Segment s1 = new Segment(3, new Point(1.2, 2.4), new Point(5.2, 0.5));
            Console.WriteLine(s1);

            Dreptunghi d1 = new Dreptunghi(4, new Point(1.2, 2.4), new Point(3.2, 0.5));
            Console.WriteLine(d1);

            Elipsa e1 = new Elipsa(5, new Point(6.2, 2.4), new Point(8.2, 0.5))
        }
    }
}
