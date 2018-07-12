using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Airport.BLL.Interfaces;
using Airport.DAL.Interfaces;
using Airport.DAL.Models;
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


        public TicketDto GetTicket(Guid? id)
        {
            if (!id.HasValue)
            {
                throw new ArgumentNullException();
            }

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Ticket, TicketDto>()).CreateMapper();
            return mapper.Map<Ticket, TicketDto>(DB.TicketRepository.Get(id.Value));
        }

        public IEnumerable<TicketDto> GetTickets()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Ticket, TicketDto>()).CreateMapper();
            return mapper.Map<IEnumerable<Ticket>, List<TicketDto>>(DB.TicketRepository.GetAll());
        }

        public void CreateTicket(TicketDto ticketDto)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Ticket, TicketDto>()).CreateMapper();
            var ticket = mapper.Map<TicketDto, Ticket>(ticketDto);

            Ticket foundedTicket = DB.TicketRepository.Get(ticketDto.Id);

            // Validation
            if (foundedTicket != null)
            {
                throw new ArgumentException("Ticket have already exist");
            }

            DB.TicketRepository.Create(ticket);
        }
    }
}
