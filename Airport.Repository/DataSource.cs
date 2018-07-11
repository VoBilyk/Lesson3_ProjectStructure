using System;
using System.Collections.Generic;
using System.Text;
using Airport.Repository.Models;

namespace Airport.Repository
{
    public class DataSource
    {
        public List<Ticket> Tickets
        {
            get
            {
                return new List<Ticket> { new Ticket { Id = Guid.NewGuid(), Price = 49.90M } };
            }
        }

    }
}
