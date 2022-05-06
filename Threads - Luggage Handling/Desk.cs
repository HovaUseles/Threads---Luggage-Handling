using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads___Luggage_Handling
{
    internal class Desk
    {
        Thread thread;

        Queue<Luggage> luggageLine;

        public Desk()
        {
            thread = new Thread(ThreadController);
            luggageLine = new Queue<Luggage>();
        }

        public void StartThread()
        {
            thread.Start();
        }

        private void ThreadController()
        {

        }

        private void HandleLuggage()
        {

        }

        private Ticket Ticket()
        {


            return new Ticket();
        }
    }
}
