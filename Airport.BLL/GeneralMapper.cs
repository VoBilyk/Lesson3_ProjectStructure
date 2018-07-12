using AutoMapper;
using Airport.DAL.Models;
using Shared.DTO;

namespace Airport.BLL
{
    public class Configuration
    {
        public MapperConfiguration MapperConfiguration()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Aeroplane, AeroplaneDto>();
                cfg.CreateMap<AeroplaneDto, Aeroplane>();

                cfg.CreateMap<AeroplaneType, AeroplaneTypeDto>();
                cfg.CreateMap<AeroplaneTypeDto, AeroplaneType>();

                cfg.CreateMap<Crew, CrewDto>();
                cfg.CreateMap<CrewDto, Crew>();

                cfg.CreateMap<Flight, FlightDto>();
                cfg.CreateMap<FlightDto, Flight>();

                cfg.CreateMap<Pilot, PilotDto>();
                cfg.CreateMap<PilotDto, Pilot>();

                cfg.CreateMap<Stewardess, StewardessDto>();
                cfg.CreateMap<StewardessDto, Stewardess>();

                cfg.CreateMap<Ticket, TicketDto>();
                cfg.CreateMap<TicketDto, Ticket>();
            });

            return config;
        }
    }
}
