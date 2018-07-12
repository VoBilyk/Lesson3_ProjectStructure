using System;
using System.Collections.Generic;
using System.Text;
using Shared.DTO;

namespace Airport.BLL.Interfaces
{
    public interface ITicketService
    {
        void CreateTicket(TicketDto ticketDto);

        TicketDto GetTicket(int? id);

        IEnumerable<TicketDto> GetTickets();
    }
}
