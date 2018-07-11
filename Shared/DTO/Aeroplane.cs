using System;

namespace Shared.DTO
{
    public class Aeroplane
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public AeroplaneType AeroplaneType { get; set; }

        public TimeSpan Lifetime { get; set; }
    }
}
