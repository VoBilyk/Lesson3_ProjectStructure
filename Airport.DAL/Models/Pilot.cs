using Airport.DAL.Interfaces;
using System;

namespace Airport.DAL.Models
{
    public class Pilot : IEntity
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public int Experience { get; set; }

        public DateTime BirthDate { get; set; }
    }
}
