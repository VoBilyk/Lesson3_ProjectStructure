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

        public List<TicketDto> GetAll()
        {
            return mapper.Map<List<Ticket>, List <TicketDto>>(db.TicketRepository.GetAll());
        }

        public TicketDto Create(TicketDto ticketDto)
        {
            var ticket = mapper.Map<TicketDto, Ticket>(ticketDto);
            ticket.Id = Guid.NewGuid();
            ticket.Flight = db.FlightRepository.Get(ticketDto.FlightId);

            db.TicketRepository.Create(ticket);

            return mapper.Map<Ticket, TicketDto>(ticket);
        }

        public TicketDto Update(Guid id, TicketDto ticketDto)
        {
            var ticket = mapper.Map<TicketDto, Ticket>(ticketDto);
            ticket.Id = id;
            ticket.Flight = db.FlightRepository.Get(ticketDto.FlightId);
            
            db.TicketRepository.Update(ticket);

            return mapper.Map<Ticket, TicketDto>(ticket);
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
