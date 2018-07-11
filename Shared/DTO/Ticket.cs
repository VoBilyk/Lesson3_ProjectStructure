using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.DTO
{
    public class Ticket
    {
        public Guid Id { get; set; }

        public decimal Price { get; set; }

        public Flight Flight { get; set; }
    }
}
