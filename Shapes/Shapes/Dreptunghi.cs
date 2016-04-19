using System;

namespace Shapes
{
    internal class Dreptunghi : Shape
    {


        public Dreptunghi(int v, Point point1, Point point2) : base(v, point1, point2)
        {
            System.Console.WriteLine("Am creat un dreptunghi");
        }


        public double Width
        {
            get
            {
                return Math.Abs(p1.X - p2.X);
            }
        }
        public double Height
        {
            get
            {
                return Math.Abs(p1.Y - p2.Y);
            }
        }
        public double Area
        {
            get
            {
                return Width * Height;
            }
        }
    }
}