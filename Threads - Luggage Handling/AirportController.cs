using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads___Luggage_Handling
{
    internal class AirportController
    {
        LuggageGenerator luggageGenerator;

        /// <summary>
        /// Luggage storage before it enters the airport systems.
        /// </summary>
        Luggage[] luggagePool;

        /// <summary>
        /// Inializes an instance of the AirportController
        /// </summary>
        public AirportController()
        {
            luggagePool = new Luggage[30];
            luggageGenerator = new LuggageGenerator(luggagePool);

        }

        /// <summary>
        /// Starts the luggage thread luggage generation
        /// </summary>
        public void StartLuggageGen()
        {
            luggageGenerator.StartThread();
        }

        /// <summary>
        /// Joins the threads to end all threads together when main thread ends.
        /// </summary>
        public void ThreadJoin()
        {
            luggageGenerator.GetThread.Join();
        }

        public void HandleLuggage()
        {

        }

        public void CreateDesk()
        {

        }

    }
}
