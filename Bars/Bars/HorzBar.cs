namespace Bars
{
    public class HorzBar
    {
        private int length;

        public HorzBar(int v)
        {
            length = v;
            System.Console.Write("+");
            for (int i = 0; i < length; i++)
            {
                System.Console.Write("-");
            }
            System.Console.WriteLine("+");
        }

        #region Properties
        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }
        #endregion
    }
}