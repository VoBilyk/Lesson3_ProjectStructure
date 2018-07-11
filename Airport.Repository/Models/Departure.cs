using System;

namespace Airport.Repository.Models
{
    public class Departure
    {
        public Guid Id { get; set; }

        public DateTime Time { get; set; }

        public Crew Crew { get; set; }

        public Airplane Airplane { get; set; }
    }
}
