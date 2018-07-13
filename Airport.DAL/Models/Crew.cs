using Airport.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.DAL.Models
{
    public class Crew : IEntity
    {
        public Guid Id { get; set; }

        public Pilot Pilot { get; set; }

        public List<Stewardess> Stewardesses { get; set; }
    }
}
