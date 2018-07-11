using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.Repository.Models
{
    public class AeroplaneType
    {
        public Guid Id { get; set; }

        public string Model { get; set; }

        public int Places { get; set; }

        public int Carrying { get; set; }
    }
}
