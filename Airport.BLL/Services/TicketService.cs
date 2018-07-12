using System;
using System.Collections.Generic;
using AutoMapper;
using Airport.BLL.Interfaces;
using Airport.DAL.Interfaces;
using Airport.DAL.Models;
using Airport.Shared.DTO;

namespace Airport.BLL.Services
{
    public class TicketService : ITicketService
    {
        private IUnitOfWork db;
        private IMapper mapper;

        public TicketService(IUnitOfWork uow, IMapper mapper)
        {
            this.db = uow;
            this.mapper = mapper;
        }


        public TicketDto Get(Guid id)
        {
            return mapper.Map<Ticket, TicketDto>(db.TicketRepository.Get(id));
        }

        public IEnumerable<TicketDto> GetAll()
        {
            return mapper.Map<IEnumerable<Ticket>, IEnumerable <TicketDto>>(db.TicketRepository.GetAll());
        }

        public TicketDto Create(TicketDto ticketDto)
        {
            ticketDto.Id = Guid.NewGuid();
            var ticket = mapper.Map<TicketDto, Ticket>(ticketDto);
            var resultTicket = db.TicketRepository.Create(ticket);

            return mapper.Map<Ticket, TicketDto>(resultTicket);
        }

        public TicketDto Update(Guid id, TicketDto ticketDto)
        {
            ticketDto.Id = id;
            var ticket = mapper.Map<TicketDto, Ticket>(ticketDto);
            var resultTicket = db.TicketRepository.Update(ticket);

            return mapper.Map<Ticket, TicketDto>(resultTicket);
        }

        public void Delete(Guid id)
        {
            db.TicketRepository.Delete(id);
        }

        public void DeleteAll()
        {
            db.TicketRepository.Delete();
        }
    }
}
