using System;
using System.Collections.Generic;
using System.Text;
using Airport.DAL.Interfaces;
using Airport.DAL.Models;

namespace Airport.DAL
{
    public class UnitOfWork
    {
        private DataSource db = new DataSource();

        private Repository<Ticket> ticketRepository;
        private Repository<Aeroplane> aeroplaneRepository;
        private Repository<AeroplaneType> aeroplaneTypeRepositiry;
        private Repository<Crew> crewRepositiry;
        private Repository<Departure> departureRepository;
        private Repository<Flight> flightRepository;
        private Repository<Pilot> pilotRepository;
        private Repository<Stewardess> stewardessRepository;
        

        public IRepository<Ticket> TicketRepository
        {
            get
            {
                if (this.ticketRepository == null)
                {
                    this.ticketRepository = new Repository<Ticket>(db.Tickets);
                }
                return ticketRepository;
            }
        }

        public IRepository<Aeroplane> AeroplaneRepository
        {
            get
            {
                if (this.aeroplaneRepository == null)
                {
                    this.aeroplaneRepository = new Repository<Aeroplane>(db.Aeroplanes);
                }
                return aeroplaneRepository;
            }
        }

        public IRepository<AeroplaneType> AeroplaneTypeRepository
        {
            get
            {
                if (this.aeroplaneTypeRepositiry == null)
                {
                    this.aeroplaneTypeRepositiry = new Repository<AeroplaneType>(db.AeroplaneTypes);
                }
                return aeroplaneTypeRepositiry;
            }
        }

        public IRepository<Crew> CrewRepositiry
        {
            get
            {
                if (this.crewRepositiry == null)
                {
                    this.crewRepositiry = new Repository<Crew>(db.Crews);
                }
                return crewRepositiry;
            }
        }

        public IRepository<Departure> DepartureRepository
        {
            get
            {
                if (this.departureRepository == null)
                {
                    this.departureRepository = new Repository<Departure>(db.Departures);
                }
                return departureRepository;
            }
        }

        public IRepository<Flight> FlightRepository
        {
            get
            {
                if (this.flightRepository == null)
                {
                    this.flightRepository = new Repository<Flight>(db.Flights);
                }
                return flightRepository;
            }
        }

        public IRepository<Pilot> PilotRepositiry
        {
            get
            {
                if (this.pilotRepository == null)
                {
                    this.pilotRepository = new Repository<Pilot>(db.Pilots);
                }
                return pilotRepository;
            }
        }

        public IRepository<Stewardess> StewardessRepositiry
        {
            get
            {
                if (this.stewardessRepository == null)
                {
                    this.stewardessRepository = new Repository<Stewardess>(db.Stewardesses);
                }
                return stewardessRepository;
            }
        }
    }
}
