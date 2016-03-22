using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValRef
{
    class X
    {
        private int id;
        public X(int id)
        {
            this.id = id;
        }
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
    }
    class Program
    {
        static void SwapVal(int a, int b)
        {
            int c;
            c = a;
            a = b;
            b = c;
        }

        static void SwapRef(ref int a, ref int b)
        {
            int c;
            c = a;
            a = b;
            b = c;
        }

        static void SwapRefByVal(X a, X b)
        {
            X c;
            c = a;
            a = b;
            b = c;
        }


        static void SwapRefByRef(ref X a, ref X b)
        {
            X c;
            c = a;
            a = b;
            b = c;
        }
        static void ModifRef(X x)
        {
            x.ID = 3;
        }
        static void Main(string[] args)
        {
            int x = 1, y = 2;

            Console.WriteLine("Before: {0}, {1}", x, y);
            SwapVal(x, y);
            Console.WriteLine("After: {0}, {1}", x, y);

            Console.WriteLine("Before: {0}, {1}", x, y);
            SwapRef(ref x, ref y);
            Console.WriteLine("After: {0}, {1}", x, y);


            X x1, x2;

            x1 = new X(1);
            x2 = new X(2);


            Console.WriteLine("Before: {0}, {1}", x1.ID, x2.ID);
            SwapRefByVal(x1, x2);
            Console.WriteLine("After: {0}, {1}", x1.ID, x2.ID);

            ModifRef(x1);
            Console.WriteLine("Modificare obiect referit: {0}", x1.ID);


            Console.WriteLine("Before: {0}, {1}", x1.ID, x2.ID);
            SwapRefByRef(ref x1, ref x2);
            Console.WriteLine("After: {0}, {1}", x1.ID, x2.ID);

        }
    }
}
