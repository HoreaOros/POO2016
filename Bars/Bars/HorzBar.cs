namespace Bars
{
    /// <summary>
    /// O bara orizonala de tipul +---+
    /// </summary>
    public class HorzBar
    {
        /// <summary>
        /// Lungimea barei orizontale
        /// </summary>
        private int length;

        /// <summary>
        /// Metoda constructor a barei orizontale
        /// </summary>
        /// <param name="v">Lungimea barei orizontale</param>
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
        /// <summary>
        /// Get - set lungime bara orizontala
        /// </summary>
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