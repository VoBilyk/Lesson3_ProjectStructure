using Airport.DAL.Interfaces;
using System;

namespace Airport.DAL.Models
{
    public class Departure : IEntity
    {
        public Guid Id { get; set; }

        public DateTime Time { get; set; }

        public Crew Crew { get; set; }

        public Aeroplane Airplane { get; set; }
    }
}
