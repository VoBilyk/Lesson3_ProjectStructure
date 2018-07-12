using System;
using System.Collections.Generic;
using System.Text;
using Airport.DAL.Interfaces;
using Airport.DAL.Models;

namespace Airport.DAL
{
    public class DataSource
    {
        static List<Ticket> tickets = new List<Ticket> { new Ticket { Id = Guid.NewGuid(), Price = 49.90M } };
        static List<Pilot> pilots = new List<Pilot> { new Pilot { Id = Guid.NewGuid(), FirstName = "Jonh"  } };



        public List<TEntity> SetOf<TEntity>()
        {
            if (tickets is List<TEntity>)
            {
                return tickets as List<TEntity>;
            }
            else if(pilots is List<TEntity>)
            {
                return pilots as List<TEntity>;
            }

            return null;
        }

        public List<Ticket> Tickets => tickets;

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
