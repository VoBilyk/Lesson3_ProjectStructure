﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.DTO
{
    public class Flight
    {
        public Guid Id { get; set; }

        public string DeparturePoint { get; set; }

        public string Destinition { get; set; }

        public DateTime ArrivalTime { get; set; }

        public DateTime DepartureTime { get; set; }

        public List<Ticket> Tickets { get; set; }
    }
}