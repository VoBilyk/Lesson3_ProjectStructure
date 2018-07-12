using System;
using System.Collections.Generic;
using System.Text;
using Airport.BLL.Interfaces;
using Airport.DAL.Interfaces;
using Shared.DTO;

namespace Airport.BLL.Services
{
    public class TicketService : ITicketService
    {
        IUnitOfWork DB { get; set; }

        public TicketService(IUnitOfWork uow)
        {
            DB = uow;
        }


        public void CreateTicket(TicketDto ticketDto)
        {
            throw new NotImplementedException();
        }

        public TicketDto GetTicket(int? id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TicketDto> GetTickets()
        {
            throw new NotImplementedException();
        }
    }
}
