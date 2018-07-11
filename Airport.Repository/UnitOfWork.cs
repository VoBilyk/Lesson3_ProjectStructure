using System;
using System.Collections.Generic;
using System.Text;
using Airport.Repository.Models;

namespace Airport.Repository
{
    public class UnitOfWork
    {
        private DataSource db = new DataSource();

        private Repository ticketRepository;

        public IRepository<Ticket> GetTickets
        {
            get
            {
                if (this.ticketRepository == null)
                {
                    this.ticketRepository = new Repository<Ticket>(db.Tickets);
                }
                return ticketRepository;
            }
        }
    }
}
