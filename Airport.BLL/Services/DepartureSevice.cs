using System;
using System.Collections.Generic;
using AutoMapper;
using Airport.BLL.Interfaces;
using Airport.DAL.Interfaces;
using Airport.DAL.Models;
using Airport.Shared.DTO;


namespace Airport.BLL.Services
{
    public class DepartureService : IDepartureService
    {
        private IUnitOfWork db;
        private IMapper mapper;

        public DepartureService(IUnitOfWork uow, IMapper mapper)
        {
            this.db = uow;
            this.mapper = mapper;
        }


        public DepartureDto Get(Guid id)
        {
            return mapper.Map<Departure, DepartureDto>(db.DepartureRepository.Get(id));
        }

        public IEnumerable<DepartureDto> GetAll()
        {
            return mapper.Map<IEnumerable<Departure>, IEnumerable<DepartureDto>>(db.DepartureRepository.GetAll());
        }

        public DepartureDto Create(DepartureDto departureDto)
        {
            departureDto.Id = Guid.NewGuid();
            var departure = mapper.Map<DepartureDto, Departure>(departureDto);
            var resultDeparture = db.DepartureRepository.Create(departure);

            return mapper.Map<Departure, DepartureDto>(resultDeparture);
        }

        public DepartureDto Update(Guid id, DepartureDto departureDto)
        {
            departureDto.Id = id;
            var departure = mapper.Map<DepartureDto, Departure>(departureDto);
            var resultDeparture = db.DepartureRepository.Update(departure);

            return mapper.Map<Departure, DepartureDto>(resultDeparture);
        }

        public void Delete(Guid id)
        {
            db.DepartureRepository.Delete(id);
        }

        public void DeleteAll()
        {
            db.DepartureRepository.Delete();
        }
    }
}