using System;
using System.Collections.Generic;
using AutoMapper;
using Airport.BLL.Interfaces;
using Airport.DAL.Interfaces;
using Airport.DAL.Models;
using Airport.Shared.DTO;

namespace Airport.BLL.Services
{
    public class PilotService : IPilotService
    {
        private IUnitOfWork db;
        private IMapper mapper;

        public PilotService(IUnitOfWork uow, IMapper mapper)
        {
            this.db = uow;
            this.mapper = mapper;
        }


        public PilotDto Get(Guid id)
        {
            return mapper.Map<Pilot, PilotDto>(db.PilotRepositiry.Get(id));
        }

        public IEnumerable<PilotDto> GetAll()
        {
            return mapper.Map<IEnumerable<Pilot>, IEnumerable<PilotDto>>(db.PilotRepositiry.GetAll());
        }

        public PilotDto Create(PilotDto pilotDto)
        {
            pilotDto.Id = Guid.NewGuid();
            var pilot = mapper.Map<PilotDto, Pilot>(pilotDto);
            var resultPilot = db.PilotRepositiry.Create(pilot);

            return mapper.Map<Pilot, PilotDto>(resultPilot);
        }

        public PilotDto Update(Guid id, PilotDto pilotDto)
        {
            pilotDto.Id = id;
            var pilot = mapper.Map<PilotDto, Pilot>(pilotDto);
            var resultPilot = db.PilotRepositiry.Update(pilot);

            return mapper.Map<Pilot, PilotDto>(resultPilot);
        }

        public void Delete(Guid id)
        {
            db.PilotRepositiry.Delete(id);
        }

        public void DeleteAll()
        {
            db.PilotRepositiry.Delete();
        }
    }
}