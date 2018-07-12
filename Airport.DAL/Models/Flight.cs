using Airport.DAL.Interfaces;
using System;
using System.Collections.Generic;

namespace Airport.DAL.Models
{
    public class Flight : IEntity
    {
        public Guid Id { get; set; }

        public string DeparturePoint { get; set; }

        public string Destinition { get; set; }

        public DateTime ArrivalTime { get; set; }

        public DateTime DepartureTime { get; set; }

        public List<Ticket> Tickets { get; set; }
    }
}
