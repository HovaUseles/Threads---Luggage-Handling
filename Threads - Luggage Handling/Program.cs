using System;
using System.Threading;


namespace Threads___Luggage_Handling
{
    public static class Program
    {
        public static bool running = true;
        public static int hundredOverFifteen = 100 / 15;
        public static void Main()
        {
            AirportController deskController = new AirportController();
            deskController.StartLuggageGen();

            while(running)
            {
                if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    running = false;
                }
            }

            deskController.ThreadJoin();
        }
    }
}