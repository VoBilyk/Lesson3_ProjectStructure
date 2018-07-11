using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.DTO
{
    public class Pilot
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public TimeSpan Experience { get; set; }
    }
}
