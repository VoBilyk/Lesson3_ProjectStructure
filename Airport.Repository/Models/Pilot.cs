using System;

namespace Airport.Repository.Models
{
    public class Pilot : IEntity
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public TimeSpan Experience { get; set; }
    }
}
