using Airport.DAL.Interfaces;
using System;

namespace Airport.DAL.Models
{
    public class Aeroplane : IEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public AeroplaneType AeroplaneType { get; set; }

        public TimeSpan Lifetime { get; set; }
    }
}
