using Airport.DAL.Interfaces;
using System;

namespace Airport.DAL.Models
{
    public class Stewardess : IEntity
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public DateTime BirthDate { get; set; }
    }
}
