using System;

namespace Cont
{
    internal class ContBancar
    {
        #region Fields
        private int sold;
        private string titular;
        private int contor;
        #endregion

        #region Constructors
        public ContBancar(string titular)
        {
            sold = 0;
            contor = 0;
            this.titular = titular;
        }
        #endregion

        #region Public members
        /// <summary>
        /// Depune o suma de bani in cont
        /// </summary>
        /// <param name="v">Suma depusa</param>
        public void Depune(int v)
        {
            contor++;
            Console.WriteLine("#{1} - Depunere: {0}", v, contor);
            if (v >= 0)
            {
                this.sold += v;
                Console.WriteLine("\tOperatie reusita.");
            }
            else
            {
                Console.WriteLine("\tOperatie refuzata. Nu se pot depune sume negative.");
            }

        }
        /// <summary>
        /// Retrage o suma de bani din cont
        /// </summary>
        /// <param name="v">Suma retrasa</param>
        public void Retrage(int v)
        {
            contor++;
            Console.WriteLine("#{1} - Retragere: {0}", v, contor);
            if (v <= sold)
            {
                Console.WriteLine("\tOperatie reusita.");
                sold -= v;
            }
            else
            {
                Console.WriteLine("\tOperatie de retragere refuzata. Fonduri insuficiente.");
            }
        }
        #endregion

        #region Public properties
        public int Sold
        {
            get
            {
                contor++;
                Console.WriteLine("#{0} - Interograre sold", contor);
                return sold;
            }
        }
        #endregion
        public override string ToString()
        {
            return "Contul al carui titular este " + titular + " are soldul " + sold.ToString();
        } 
    }
}