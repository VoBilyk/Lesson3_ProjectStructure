using System.Collections.Generic;
using Airport.DAL.Models;

namespace Airport.DAL.Repositories
{
    public class AeroplaneRepository : GenericRepository<Aeroplane>
    {
        public AeroplaneRepository(List<Aeroplane> contex) : base(contex) { }
    }
}
