using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.DTO
{
    public class AeroplaneTypeDto
    {
        public Guid Id { get; set; }

        public string Model { get; set; }

        public int Places { get; set; }

        public int Carrying { get; set; }
    }
}
