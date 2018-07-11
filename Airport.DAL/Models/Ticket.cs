using System;

namespace Airport.Repository.Models
{
    public class Ticket : IEntity
    {
        public Guid Id { get; set; }

        public decimal Price { get; set; }

        public Flight Flight { get; set; }
    }
}
