using System;
using System.Collections.Generic;
using System.Text;
using Airport.BLL.Interfaces;
using Airport.DAL.Interfaces;
using Airport.DAL.Models;
using Airport.Shared.DTO;
using AutoMapper;

namespace Airport.BLL.Services
{
    public class AeroplaneService : IService<AeroplaneDto>
    {
        private IUnitOfWork db;
        private IMapper mapper;

        public AeroplaneService(IUnitOfWork uow, IMapper mapper)
        {
            this.db = uow;
            this.mapper = mapper;
        }


        public AeroplaneDto Get(Guid id)
        {
            return mapper.Map<Aeroplane, AeroplaneDto>(db.AeroplaneRepository.Get(id));
        }

        public IEnumerable<AeroplaneDto> GetAll()
        {
            return mapper.Map<IEnumerable<Aeroplane>, IEnumerable<AeroplaneDto>>(db.AeroplaneRepository.GetAll());
        }

        public AeroplaneDto Create(AeroplaneDto aeroplaneDto)
        {
            aeroplaneDto.Id = Guid.NewGuid();
            var aeroplane = mapper.Map<AeroplaneDto, Aeroplane>(aeroplaneDto);
            var resultAeroplane = db.AeroplaneRepository.Create(aeroplane);

            return mapper.Map<Aeroplane, AeroplaneDto>(resultAeroplane);
        }

        public AeroplaneDto Update(Guid id, AeroplaneDto aeroplaneDto)
        {
            aeroplaneDto.Id = id;
            var aeroplane = mapper.Map<AeroplaneDto, Aeroplane>(aeroplaneDto);
            var resultAeroplane = db.AeroplaneRepository.Update(aeroplane);

            return mapper.Map<Aeroplane, AeroplaneDto>(resultAeroplane);
        }

        public void Delete(Guid id)
        {
            db.AeroplaneRepository.Delete(id);
        }

        public void DeleteAll()
        {
            db.AeroplaneRepository.Delete();
        }
    }
}
