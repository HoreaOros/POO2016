using System;
using System.Text;
using System.Diagnostics;

namespace Shapes
{
    internal class Shape
    {
        int id;
        protected Point p1, p2;
        public Shape(int id): this(id, new Point(0.0, 0.0), new Point(0.0, 0.0))
        {
        }
        public Shape(int id, Point p1, Point p2)
        {
            this.id = id;
            this.p1 = p1;
            this.p2 = p2;

            Console.WriteLine("Am creat un Shape");
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("ID: "); sb.Append(id);
            sb.Append(Environment.NewLine);
            sb.AppendFormat("P1: {0}", p1);
            sb.Append(Environment.NewLine);
            sb.AppendFormat("P2: {0}", p2);

            return sb.ToString();
        }
    }

    struct Point
    {
        private double x, y;
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("({0}, {1})", x, y);

            return sb.ToString();
        }
        public double X
        {
            get
            {
                return x;
            }
        }
        public double Y
        {
            get
            {
                return y;
            }
        }
    }
}