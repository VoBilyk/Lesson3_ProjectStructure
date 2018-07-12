using System.Collections.Generic;
using Airport.DAL.Models;

namespace Airport.DAL.Repositories
{
    public class FlightRepository : GenericRepository<Flight>
    {
        public FlightRepository(List<Flight> contex) : base(contex) { }
    }
}
