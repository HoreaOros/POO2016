using System;

namespace Bars
{
    internal class VertBar
    {
        private int height;

        public VertBar(int v)
        {
            height = v;
            for (int i = 0; i < height; i++)
            {
                Console.WriteLine("|");
            }
        }
        public int Height
        {
            get
            {
                return height;
            }
        }
    }
}