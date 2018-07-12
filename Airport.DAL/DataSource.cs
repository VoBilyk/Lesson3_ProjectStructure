using System;
using System.Collections.Generic;
using Airport.DAL.Models;
using Bogus;

namespace Airport.DAL
{
    public class DataSource
    {
        static List<Ticket> tickets;
        static List<Pilot> pilots;
        static List<Crew> crews;
        static List<Stewardess> stewardesses;
        static List<Aeroplane> aeroplanes;
        static List<AeroplaneType> aeroplaneTypes;
        static List<Flight> flights;
        static List<Departure> departures;


        static DataSource()
        {
            var pilotFaker = new Faker<Pilot>()
                .RuleFor(o => o.Id, Guid.NewGuid())
                .RuleFor(o => o.FirstName, f => f.Name.FirstName())
                .RuleFor(o => o.SecondName, f => f.Name.LastName())
                .RuleFor(o => o.Experience, new TimeSpan(Randomizer.Seed.Next(1000000)));

            pilots = pilotFaker.Generate(10);


            var ticketFaker = new Faker<Ticket>()
                .RuleFor(o => o.Id, Guid.NewGuid())
                .RuleFor(o => o.Price, f => f.Random.Number(20, 100));

            tickets = ticketFaker.Generate(10);
        }



        public List<TEntity> SetOf<TEntity>()
        {
            if (tickets is List<TEntity>)
            {
                return tickets as List<TEntity>;
            }
            else if (pilots is List<TEntity>)
            {
                return pilots as List<TEntity>;
            }

            return null;
        }

        public List<Ticket> Tickets => tickets;

        public List<Aeroplane> Aeroplanes => aeroplanes;

        public List<AeroplaneType> AeroplaneTypes => aeroplaneTypes;

        public List<Crew> Crews => crews;

        public List<Departure> Departures = departures;

        public List<Flight> Flights => flights;

        public List<Pilot> Pilots => pilots;

        public List<Stewardess> Stewardesses => stewardesses;
    }
}
