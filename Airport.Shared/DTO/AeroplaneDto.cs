using System;

namespace Airport.Shared.DTO
{
    public class AeroplaneDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public AeroplaneTypeDto AeroplaneType { get; set; }

        public TimeSpan Lifetime { get; set; }
    }
}
