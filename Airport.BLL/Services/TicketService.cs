using System;
using System.Collections.Generic;
using AutoMapper;
using Airport.BLL.Interfaces;
using Airport.DAL.Interfaces;
using Airport.DAL.Models;
using Airport.Shared.DTO;

namespace Airport.BLL.Services
{
    public class TicketService : IService<TicketDto>
    {
        IUnitOfWork DB { get; set; }

        public TicketService(IUnitOfWork uow, IMapper mapper)
        {
            DB = uow;
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

        public TicketDto Get(Guid? id)
        {
            if (!id.HasValue)
            {
                throw new ArgumentNullException();
            }

            var mapper = Configuration.MapperConfiguration().CreateMapper();
            return mapper.Map<Ticket, TicketDto>(DB.TicketRepository.Get(id.Value));
            //var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Ticket, TicketDto>()).CreateMapper();
            //return mapper.Map<Ticket, TicketDto>(DB.TicketRepository.Get(id.Value));
        }

        public IEnumerable<TicketDto> GetAll()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Ticket, TicketDto>()).CreateMapper();
            return mapper.Map<IEnumerable<Ticket>, List<TicketDto>>(DB.TicketRepository.GetAll());
        }

        public TicketDto Create(TicketDto ticketDto)
        {
            ticketDto.Id = Guid.NewGuid();

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Ticket, TicketDto>()).CreateMapper();
            var ticket = mapper.Map<TicketDto, Ticket>(ticketDto);
            DB.TicketRepository.Create(ticket);
        }

        public TicketDto Update(Guid? id, TicketDto dto)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid? id)
        {
            DB.TicketRepository.Delete(id.Value);
        }

        public void DeleteAll()
        {
            DB.TicketRepository.Delete();
        }
    }
}
