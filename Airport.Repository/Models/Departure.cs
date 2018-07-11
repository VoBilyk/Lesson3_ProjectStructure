using System;

namespace Airport.Repository.Models
{
    public class Departure : IEntity
    {
        public Guid Id { get; set; }

        public DateTime Time { get; set; }

        public Crew Crew { get; set; }

        public Aeroplane Airplane { get; set; }
    }
}
