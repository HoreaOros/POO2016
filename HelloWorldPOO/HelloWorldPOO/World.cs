using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldPOO
{
    class World
    {
        #region Data member
        string id;
        #endregion

        #region Constructors
        // metoda constructor
        public World(string v)
        {
            id = v;
        }

        public World()
        {
            //id = "...";
        }
        #endregion


        #region Public methods
        public void SayHello()
        {
            Console.WriteLine("Hello World from {0}", id);
        }
        #endregion
    }
}
