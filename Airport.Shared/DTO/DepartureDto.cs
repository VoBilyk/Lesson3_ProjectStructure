using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.Shared.DTO
{
    public class DepartureDto
    {
        public Guid Id { get; set; }

        public DateTime Time { get; set; }

        public CrewDto Crew { get; set; }

        public AeroplaneDto Airplane { get; set; }
    }
}
