﻿using System;
using System.Collections.Generic;
using System.Linq;
using Airport.BLL.Interfaces;
using Airport.DAL.Interfaces;
using Airport.DAL.Models;
using Airport.Shared.DTO;
using AutoMapper;

namespace Airport.BLL.Services
{
    public class CrewService : ICrewService
    {
        private IUnitOfWork db;
        private IMapper mapper;

        public CrewService(IUnitOfWork uow, IMapper mapper)
        {
            this.db = uow;
            this.mapper = mapper;
        }


        public CrewDto Get(Guid id)
        {
            return mapper.Map<Crew, CrewDto>(db.CrewRepositiry.Get(id));
        }

        public List<CrewDto> GetAll()
        {
            return mapper.Map<List<Crew>, List<CrewDto>>(db.CrewRepositiry.GetAll());
        }

        public CrewDto Create(CrewDto crewDto)
        {
            var crew = mapper.Map<CrewDto, Crew>(crewDto);

            crew.Id = Guid.NewGuid();
            crew.Pilot = db.PilotRepositiry.Get(crewDto.PilotId);
            crew.Stewardesses = db.StewardessRepositiry.GetAll().Where(i => crewDto.StewardessesId.Contains(i.Id)).ToList();
            
            db.CrewRepositiry.Create(crew);

            return mapper.Map<Crew, CrewDto>(crew);
        }

        public CrewDto Update(Guid id, CrewDto crewDto)
        {
            var crew = mapper.Map<CrewDto, Crew>(crewDto);

            crew.Id = id;
            crew.Pilot = db.PilotRepositiry.Get(crewDto.PilotId);
            crew.Stewardesses = db.StewardessRepositiry.GetAll().Where(i => crewDto.StewardessesId.Contains(i.Id)).ToList();

            db.CrewRepositiry.Update(crew);

            return mapper.Map<Crew, CrewDto>(crew);
        }

        public void Delete(Guid id)
        {
            db.CrewRepositiry.Delete(id);
        }

        public void DeleteAll()
        {
            db.CrewRepositiry.Delete();
        }
    }
}