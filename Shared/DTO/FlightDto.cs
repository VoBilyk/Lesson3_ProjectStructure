using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.DTO
{
    public class FlightDto
    {
        public Guid Id { get; set; }

        public string DeparturePoint { get; set; }

        public string Destinition { get; set; }

        public DateTime ArrivalTime { get; set; }

        public DateTime DepartureTime { get; set; }

        public List<TicketDto> Tickets { get; set; }
    }
}
