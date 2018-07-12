using System.Collections.Generic;
using Airport.DAL.Models;

namespace Airport.DAL.Repositories
{
    public class PilotRepository : GenericRepository<Pilot>
    {
        public PilotRepository(List<Pilot> contex) : base(contex) { }
    }
}
