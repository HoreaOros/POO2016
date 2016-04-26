using System;


namespace Shapes
{
    internal class Segment : Shape, ILungime
    {

        public Segment(int v, Point point1, Point point2): base(v, point1, point2)
        {
            System.Console.WriteLine("Am creat un segment"); 
        }
        public double Lungime()
        {
            return 
                Math.Sqrt(
                    Math.Pow((p1.X - p2.X), 2) + 
                    Math.Pow((p1.Y - p2.Y), 2));
        }
        public override void Draw()
        {
            // base.Draw();
            Console.WriteLine("Am desenat un segment");
        }
    }
}