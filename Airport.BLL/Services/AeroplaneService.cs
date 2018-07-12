using System;
using System.Collections.Generic;
using System.Text;
using Airport.BLL.Interfaces;
using Airport.Shared.DTO;

namespace Airport.BLL.Services
{
    public class AeroplaneService : IService<AeroplaneDto>
    {
        public void Create(AeroplaneDto dto)
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

        public AeroplaneDto Get(Guid? id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AeroplaneDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public void UpdateTicket(AeroplaneDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
