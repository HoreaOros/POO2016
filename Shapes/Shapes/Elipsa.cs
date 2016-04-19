using System;

namespace Shapes
{
    class Elipsa: Shape, ILungime
    {
        

        public Elipsa(int v, Point point1, Point point2): base(v, point1, point2)
        {
            System.Console.WriteLine("Am creat o elipsa");
        }

        public double Lungime()
        {
            // lungimea unei elipse???
        }
    }
}