using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.Repository.Models
{
    public class Crew
    {
        public Guid Id { get; set; }

        public Pilot Pilot { get; set; }

        public List<Stewardess> Stewardesses { get; set; }
    }
}
