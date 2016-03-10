using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataCalendaristica
{
    class Program
    {
        static void Main(string[] args)
        {
            #region DateTime struct
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);
            Console.WriteLine("Ora: {0}", dt.Hour);
            Console.WriteLine("Minut: {0}", dt.Minute);
            Console.WriteLine("Secunda: {0}", dt.Second);

            DateTime dt2 = dt.AddMinutes(100);
            TimeSpan ts = dt2.Subtract(dt);

            Console.WriteLine("100 minute = {0} secunde", ts.TotalSeconds);
            Console.WriteLine(dt2);
            #endregion

            DC dc = new DC(9, 3, 2016, 8, 37, 31);

            Console.WriteLine(dc);

            ZileSaptamana z = ZileSaptamana.Miercuri;

            switch (z)
            {
                case ZileSaptamana.Luni:
                case ZileSaptamana.Marti:
                case ZileSaptamana.Miercuri:
                case ZileSaptamana.Joi:
                    Console.WriteLine("Bleaahh!");
                    break;
                case ZileSaptamana.Vineri:
                    Console.WriteLine("Finnaly. se apropie weekendul.");
                    break;
                case ZileSaptamana.Sambata:
                case ZileSaptamana.Duminica:
                    Console.WriteLine("Yeah!! ;-)");
                    break;
                default:
                    break;
            }
            byte[] array = new byte[1024];
            FileStream fs = new FileStream("input.txt", FileMode.Open);
            try
            {
                fs.Read(array, 0, array.Length);
            }
            catch (Exception)
            {
                Console.WriteLine("Oops!!! Something went wrong!");
            }
            finally
            {
                fs.Close();
            }
        }
    }
}
