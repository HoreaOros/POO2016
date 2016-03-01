using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // f();

            World w1 = new World("C#");
            w1.SayHello();

            World w2 = new World("OOP");
            w2.SayHello();


            World w3 = new World();
            w3.SayHello();


        }

        static void f()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
