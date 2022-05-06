using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads___Luggage_Handling
{
    internal class DeskController
    {

        Luggage[] luggage;
        string[] fNames;
        string[] lNames;

        /// <summary>
        /// Creates a new instance of the deskcontroller class
        /// </summary>
        public DeskController(Luggage[] bags, string[] fNameList, string[] lNameList)
        {
            luggage = bags;
            fNames = fNameList;
            lNames = lNameList;
        }

        public void HandleLuggage()
        {

        }

        public void CreateDesk()
        {

        }
    }
}
