using Airport.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.DAL.Models
{
    public class AeroplaneType : IEntity
    {
        public Guid Id { get; set; }

        public string Model { get; set; }

        public int Places { get; set; }

        public int Carrying { get; set; }
    }
}
