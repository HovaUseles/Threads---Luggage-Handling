using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads___Luggage_Handling
{
    internal class LuggageGenerator
    {
        /// <summary>
        /// Thread running the luggage generator.
        /// </summary>
        private Thread thread;
        public Thread GetThread
        {
            get { return thread; }
            private set { thread = value; }
        }

        private Luggage[] luggagePool;



        /// <summary>
        /// Creates an instance of the class with a new thread.
        /// </summary>
        public LuggageGenerator(Luggage[] bagList)
        {
            thread = new Thread(ThreadController);
            thread.Name = "Luggage Generator Thread";

            luggagePool = bagList;
        }

        /// <summary>
        /// Start the luggage generator thread 
        /// </summary>
        public void StartThread()
        {
            thread.Start();
        }

        /// <summary>
        /// Loops the operation of thread.
        /// </summary>
        private void ThreadController()
        {
            while (Program.running)
            {
                Luggage bag = GenerateLuggage();
                luggagePool.Append(bag);
                Debug.WriteLine($"Created new luggage {bag.ToString()}");
                Thread.Sleep(Program.hundredOverFifteen);
            }
        }

        /// <summary>
        /// Generates an instance of the luggage class
        /// </summary>
        /// <returns>An instance of the luggage class</returns>
        private Luggage GenerateLuggage()
        {
            Luggage bag = new Luggage();
            return bag;
        }

    }
}
