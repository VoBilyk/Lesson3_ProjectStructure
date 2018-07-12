using System;
using System.Collections.Generic;
using System.Text;
using Airport.BLL.Interfaces;
using Airport.Shared.DTO;

namespace Airport.BLL.Services
{
    public class FlightService : IService<FlightDto>
    {
        public void Create(FlightDto dto)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid? id)
        {
            throw new NotImplementedException();
        }

        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public FlightDto Get(Guid? id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FlightDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public void UpdateTicket(FlightDto dto)
        {
            throw new NotImplementedException();
        }
    }
}