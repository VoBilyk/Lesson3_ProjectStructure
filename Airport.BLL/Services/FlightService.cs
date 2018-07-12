using System;
using System.Collections.Generic;
using AutoMapper;
using Airport.BLL.Interfaces;
using Airport.DAL.Interfaces;
using Airport.DAL.Models;
using Airport.Shared.DTO;


namespace Airport.BLL.Services
{
    public class FlightService : IFlightService
    {
        private IUnitOfWork db;
        private IMapper mapper;

        public FlightService(IUnitOfWork uow, IMapper mapper)
        {
            this.db = uow;
            this.mapper = mapper;
        }


        public FlightDto Get(Guid id)
        {
            return mapper.Map<Flight, FlightDto>(db.FlightRepository.Get(id));
        }

        public IEnumerable<FlightDto> GetAll()
        {
            return mapper.Map<IEnumerable<Flight>, IEnumerable<FlightDto>>(db.FlightRepository.GetAll());
        }

        public FlightDto Create(FlightDto flightDto)
        {
            flightDto.Id = Guid.NewGuid();
            var flight = mapper.Map<FlightDto, Flight>(flightDto);
            var resultFlight = db.FlightRepository.Create(flight);

            return mapper.Map<Flight, FlightDto>(resultFlight);
        }

        public FlightDto Update(Guid id, FlightDto flightDto)
        {
            flightDto.Id = id;
            var flight = mapper.Map<FlightDto, Flight>(flightDto);
            var resultFlight = db.FlightRepository.Update(flight);

            return mapper.Map<Flight, FlightDto>(resultFlight);
        }

        public void Delete(Guid id)
        {
            db.FlightRepository.Delete(id);
        }

        public void DeleteAll()
        {
            db.FlightRepository.Delete();
        }
    }
}