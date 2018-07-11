using System;

namespace Airport.Repository.Models
{
    public class Stewardess
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public DateTime BirthDate { get; set; }
    }
}
