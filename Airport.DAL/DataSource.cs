using System;
using System.Collections.Generic;
using System.Linq;
using Airport.DAL.Models;
using Bogus;

namespace Airport.DAL
{
    public class DataSource
    {
        static List<Pilot> pilots;
        static List<Stewardess> stewardesses;
        static List<Crew> crews;
        static List<AeroplaneType> aeroplaneTypes;
        static List<Aeroplane> aeroplanes;
        static List<Departure> departures;
        static List<Flight> flights;
        static List<Ticket> tickets;


        static DataSource()
        {
            var pilotFaker = new Faker<Pilot>()
                .RuleFor(o => o.Id, f => Guid.NewGuid())
                .RuleFor(o => o.FirstName, f => f.Name.FirstName(Bogus.DataSets.Name.Gender.Male))
                .RuleFor(o => o.SecondName, f => f.Name.LastName())
                .RuleFor(o => o.BirthDate, f => f.Date.Past(30, new DateTime(1990, 1, 1)).ToUniversalTime())
                .RuleFor(o => o.Experience, f => f.Random.Number(5, 40));

            var stewardessFaker = new Faker<Stewardess>()
                .RuleFor(o => o.Id, f => Guid.NewGuid())
                .RuleFor(o => o.FirstName, f => f.Name.FirstName(Bogus.DataSets.Name.Gender.Female))
                .RuleFor(o => o.SecondName, f => f.Name.LastName())
                .RuleFor(o => o.BirthDate, f => f.Date.Past(20, new DateTime(2000, 1, 1)).ToUniversalTime());

            var crewFaker = new Faker<Crew>()
                .RuleFor(o => o.Id, f => Guid.NewGuid())
                .RuleFor(o => o.Pilot, f => f.PickRandom(pilots))
                .RuleFor(o => o.Stewardesses, f => f.PickRandom(stewardesses, Randomizer.Seed.Next(1,4)).ToList());

            var aeroplaneTypeFaker = new Faker<AeroplaneType>()
                .RuleFor(o => o.Id, f => Guid.NewGuid())
                .RuleFor(o => o.Model, f => "Boeing-" + f.Random.Number(100, 999))
                .RuleFor(o => o.Places, f => f.Random.Number(20, 300))
                .RuleFor(o => o.Carrying, f => f.Random.Number(20000, 200000));

            var aeroplaneFaker = new Faker<Aeroplane>()
                .RuleFor(o => o.Id, f => Guid.NewGuid())
                .RuleFor(o => o.AeroplaneType, f => f.PickRandom(aeroplaneTypes))
                .RuleFor(o => o.Name, f => f.Lorem.Word())
                .RuleFor(o => o.Lifetime, f => f.Date.Timespan(new TimeSpan(3000, 0, 0, 0)));

            var departureFaker = new Faker<Departure>()
                .RuleFor(o => o.Id, f => Guid.NewGuid())
                .RuleFor(o => o.Airplane, f => f.PickRandom(aeroplanes))
                .RuleFor(o => o.Crew, f => f.PickRandom(crews))
                .RuleFor(o => o.Time, f => f.Date.Soon(200).ToUniversalTime());

            var flightFaker = new Faker<Flight>()
                .RuleFor(o => o.Id, f => Guid.NewGuid())
                .RuleFor(o => o.DeparturePoint, f => f.Address.City())
                .RuleFor(o => o.Destinition, f => f.Address.City())
                .RuleFor(o => o.DepartureTime, f => f.Date.Soon(365).ToUniversalTime())
                .RuleFor(o => o.ArrivalTime, (f, o) => (o.DepartureTime + f.Date.Timespan(new TimeSpan(8,0,0))).ToUniversalTime());

            var ticketFaker = new Faker<Ticket>()
                .RuleFor(o => o.Id, f => Guid.NewGuid())
                .RuleFor(o => o.Price, f => f.Random.Number(20, 100))
                .RuleFor(o => o.Flight, f => f.PickRandom(flights));


            // Generating date
            pilots = pilotFaker.Generate(20);
            stewardesses = stewardessFaker.Generate(20);
            crews = crewFaker.Generate(5);
            aeroplaneTypes = aeroplaneTypeFaker.Generate(5);
            aeroplanes = aeroplaneFaker.Generate(20);
            departures = departureFaker.Generate(30);
            flights = flightFaker.Generate(15);
            tickets = ticketFaker.Generate(40);

            // Connecting tickets to flight
            foreach (var flight in flights)
            {
                flight.Tickets = tickets.Where(t => t.Flight.Id == flight.Id).ToList();
            }
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

        public List<Departure> Departures => departures;

        public List<Flight> Flights => flights;

        public List<Pilot> Pilots => pilots;

        public List<Stewardess> Stewardesses => stewardesses;
    }
}
