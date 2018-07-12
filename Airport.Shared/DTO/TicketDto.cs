using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.DTO
{
    public class TicketDto
    {
        public Guid Id { get; set; }

        public decimal Price { get; set; }

        public FlightDto Flight { get; set; }
    }
}
