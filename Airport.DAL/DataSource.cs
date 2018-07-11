using System;
using System.Collections.Generic;
using System.Text;
using Airport.DAL.Models;

namespace Airport.DAL
{
    public class DataSource
    {
        public List<Ticket> Tickets
        {
            get
            {
                return new List<Ticket> { new Ticket { Id = Guid.NewGuid(), Price = 49.90M } };
            }
        }

        public List<Aeroplane> Aeroplanes
        {
            get;
        }

        public List<AeroplaneType> AeroplaneTypes
        {
            get;
        }

        public List<Crew> Crews
        {
            get;
        }

        public List<Departure> Departures
        {
            get;
        }

        public List<Flight> Flights
        {
            get;
        }

        public List<Pilot> Pilots
        {
            get;
        }

        public List<Stewardess> Stewardesses
        {
            get;
        }
    }
}
