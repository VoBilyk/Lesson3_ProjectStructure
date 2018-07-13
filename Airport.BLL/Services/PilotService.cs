﻿using System;
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

        public List<PilotDto> GetAll()
        {
            return mapper.Map<List<Pilot>, List<PilotDto>>(db.PilotRepositiry.GetAll());
        }

        public void Create(PilotDto pilotDto)
        {
            var pilot = mapper.Map<PilotDto, Pilot>(pilotDto);
            pilot.Id = Guid.NewGuid();

            db.PilotRepositiry.Create(pilot);
        }

        public void Update(Guid id, PilotDto pilotDto)
        {
            var pilot = mapper.Map<PilotDto, Pilot>(pilotDto);
            pilot.Id = id;

            db.PilotRepositiry.Update(pilot);
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