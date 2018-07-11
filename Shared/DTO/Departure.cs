using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.DTO
{
    public class Departure
    {
        public Guid Id { get; set; }

        public DateTime Time { get; set; }

        public Crew Crew { get; set; }

        public Aeroplane Airplane { get; set; }
    }
}
