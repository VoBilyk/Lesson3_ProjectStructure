﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using AutoMapper;
using Airport.DAL;
using Airport.DAL.Interfaces;
using Airport.DAL.Models;
using Airport.BLL.Interfaces;
using Airport.BLL.Services;
using Airport.Shared.DTO;


namespace Airport.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            //Instance injection
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ITicketService, TicketService>();
            services.AddScoped<IAeroplaneService, AeroplaneService>();
            services.AddScoped<IAeroplaneTypeService, AeroplaneTypeService>();
            services.AddScoped<ICrewService, CrewService>();
            services.AddScoped<IPilotService, PilotService>();
            services.AddScoped<IStewardessService, StewardessService>();
            services.AddScoped<IFlightService, FlightService>();
            services.AddScoped<IDepartureService, DepartureService>();



            services.AddScoped(_ => MapperConfiguration().CreateMapper());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }

        public MapperConfiguration MapperConfiguration()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AeroplaneType, AeroplaneTypeDto>();
                cfg.CreateMap<AeroplaneTypeDto, AeroplaneType>();

                cfg.CreateMap<Pilot, PilotDto>();
                cfg.CreateMap<PilotDto, Pilot>();

                cfg.CreateMap<Stewardess, StewardessDto>();
                cfg.CreateMap<StewardessDto, Stewardess>();

                cfg.CreateMap<AeroplaneDto, Aeroplane>();
                cfg.CreateMap<Aeroplane, AeroplaneDto>()
                 .ForMember(dto => dto.AeroplaneTypeId, model => model.MapFrom(m => m.AeroplaneType.Id));

                cfg.CreateMap<CrewDto, Crew>();
                cfg.CreateMap<Crew, CrewDto>()
                 .ForMember(dto => dto.PilotId, model => model.MapFrom(m => m.Pilot.Id))
                 .ForMember(dto => dto.StewardessesId, model => model.MapFrom(m => m.Stewardesses.Select(s => s.Id)));

                cfg.CreateMap<DepartureDto, Departure>();
                cfg.CreateMap<Departure, DepartureDto>()
                 .ForMember(dto => dto.AirplaneId, model => model.MapFrom(m => m.Airplane.Id))
                 .ForMember(dto => dto.CrewId, model => model.MapFrom(m => m.Crew.Id));


                cfg.CreateMap<FlightDto, Flight>();
                cfg.CreateMap<Flight, FlightDto>()
                 .ForMember(dto => dto.TicketsId, model => model.MapFrom(m => m.Tickets.Select(t => t.Id)));

                cfg.CreateMap<TicketDto, Ticket>();
                cfg.CreateMap<Ticket, TicketDto>()
                 .ForMember(dto => dto.FlightId, model => model.MapFrom(m => m.Flight.Id));
            });

            return config;
        }
    }
}
