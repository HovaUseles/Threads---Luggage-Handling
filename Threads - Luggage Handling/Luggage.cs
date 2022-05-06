using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads___Luggage_Handling
{
    internal class Luggage
    {
        /// <summary>
        /// Luggage ID connecting the luggage to a ticket.
        /// </summary>
        private string id;
        public string GetID
        {
            get { return id; }
            private set { id = value; }
        }

        /// <summary>
        /// Time stamp for when the luggage was checked in
        /// </summary>
        private DateTime checkInTime;
        public DateTime CheckInTime
        {
            get { return checkInTime; }
            private set { checkInTime = value; }
        }

        public Luggage()
        {

        }

        /// <summary>
        /// Assigns id to the luggage object,
        /// </summary>
        /// <param name="givenID"></param>
        public void SetID(string givenID)
        {
            if (givenID != null)
            {
                this.id = givenID;

            }
        }

        /// <summary>
        /// Assign check in time for the luggage
        /// </summary>
        /// <param name="time"></param>
        public void SetCheckInTime(DateTime time)
        {
            checkInTime = time;
        }
    }
}
