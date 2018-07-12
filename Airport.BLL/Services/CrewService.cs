using System;
using System.Collections.Generic;
using Airport.BLL.Interfaces;
using Airport.DAL.Interfaces;
using Airport.DAL.Models;
using Airport.Shared.DTO;
using AutoMapper;

namespace Airport.BLL.Services
{
    public class CrewService : IService<CrewDto>
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

        public IEnumerable<CrewDto> GetAll()
        {
            return mapper.Map<IEnumerable<Crew>, IEnumerable<CrewDto>>(db.CrewRepositiry.GetAll());
        }

        public CrewDto Create(CrewDto crewDto)
        {
            crewDto.Id = Guid.NewGuid();
            var crew = mapper.Map<CrewDto, Crew>(crewDto);
            var resultCrew = db.CrewRepositiry.Create(crew);

            return mapper.Map<Crew, CrewDto>(resultCrew);
        }

        public CrewDto Update(Guid id, CrewDto crewDto)
        {
            crewDto.Id = id;
            var crew = mapper.Map<CrewDto, Crew>(crewDto);
            var resultCrew = db.CrewRepositiry.Update(crew);

            return mapper.Map<Crew, CrewDto>(resultCrew);
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