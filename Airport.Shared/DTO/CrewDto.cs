using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.Shared.DTO
{
    public class CrewDto
    {
        public Guid Id { get; set; }

        public PilotDto Pilot { get; set; }

        public List<StewardessDto> Stewardesses { get; set; }
    }
}
