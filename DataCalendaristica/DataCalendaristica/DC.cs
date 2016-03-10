using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCalendaristica
{
    class InvalidDCException: Exception
    {

    }
    enum ZileSaptamana
    {
        Luni,
        Marti,
        Miercuri,
        Joi,
        Vineri,
        Sambata,
        Duminica
    }
    struct DC
    {
        #region Private fields
        private int zi, luna, an;
        private int ora, minut, secunda;
        private bool valid;
        #endregion

        #region Public Properties
        public int Zi
        {
            get
            {
                return zi;
            }
        }
        public int Luna
        {
            get
            {
                return luna;
            }
        }
        public int An
        {
            get
            {
                return an;
            }
        }
        public int Ora
        {
            get
            {
                return ora;
            }
        }
        public int Minut
        {
            get
            {
                return minut;
            }
        }
        public int Secunda
        {
            get
            {
                return secunda;
            }
        }
        #endregion

        #region Constructors
        public DC(int zi, int luna, int an, int ora, int minut, int secunda)
        {
            this.zi = zi;
            this.luna = luna;
            this.an = an;
            this.ora = ora;
            this.minut = minut;
            this.secunda = secunda;
            this.valid = true;
            ValidateDC();
        }

        private void ValidateDC()
        {
            // if(valorile sunt incorecte)
            //      valid = false;
        }
        #endregion

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(zi);
            sb.Append(".");

            sb.AppendFormat("{0:D2}", luna);
            sb.Append(".");
            sb.Append(an);
            sb.Append(" ");
            sb.Append(ora);
            sb.Append(".");
            sb.Append(minut);
            sb.Append(".");
            sb.Append(secunda);


            return sb.ToString();

        }
    }
}
