using Airport.DAL.Interfaces;
using Airport.DAL.Repositories;
using Airport.DAL.Models;

namespace Airport.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private DataSource db = new DataSource();

        private TicketRepository ticketRepository;
        private AeroplaneRepository aeroplaneRepository;
        private AeroplaneTypeRepository aeroplaneTypeRepositiry;
        private CrewRepository crewRepositiry;
        private DepartureRepository departureRepository;
        private FlightRepository flightRepository;
        private PilotRepository pilotRepository;
        private StewardessRepository stewardessRepository;
        

        public IRepository<Ticket> TicketRepository
        {
            get
            {
                if (this.ticketRepository == null)
                {
                    this.ticketRepository = new TicketRepository(db.Tickets);
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
                    this.aeroplaneRepository = new AeroplaneRepository(db.Aeroplanes);
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
                    this.aeroplaneTypeRepositiry = new AeroplaneTypeRepository(db.AeroplaneTypes);
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
                    this.crewRepositiry = new CrewRepository(db.Crews);
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
                    this.departureRepository = new DepartureRepository(db.Departures);
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
                    this.flightRepository = new FlightRepository(db.Flights);
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
                    this.pilotRepository = new PilotRepository(db.Pilots);
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
                    this.stewardessRepository = new StewardessRepository(db.Stewardesses);
                }
                return stewardessRepository;
            }
        }
    }
}
