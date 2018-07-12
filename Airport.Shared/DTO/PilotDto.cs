using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.Shared.DTO
{
    public class PilotDto
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public TimeSpan Experience { get; set; }
    }
}
