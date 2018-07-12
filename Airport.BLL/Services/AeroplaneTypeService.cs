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
    public class AeroplaneTypeService : IService<AeroplaneTypeDto>
    {
        private IUnitOfWork db;
        private IMapper mapper;

        public AeroplaneTypeService(IUnitOfWork uow, IMapper mapper)
        {
            this.db = uow;
            this.mapper = mapper;
        }


        public AeroplaneTypeDto Get(Guid id)
        {
            return mapper.Map<AeroplaneType, AeroplaneTypeDto>(db.AeroplaneTypeRepository.Get(id));
        }

        public IEnumerable<AeroplaneTypeDto> GetAll()
        {
            return mapper.Map<IEnumerable<AeroplaneType>, IEnumerable<AeroplaneTypeDto>>(db.AeroplaneTypeRepository.GetAll());
        }

        public AeroplaneTypeDto Create(AeroplaneTypeDto aeroplaneTypeDto)
        {
            aeroplaneTypeDto.Id = Guid.NewGuid();
            var aeroplaneType = mapper.Map<AeroplaneTypeDto, AeroplaneType>(aeroplaneTypeDto);
            var resultAeroplaneType = db.AeroplaneTypeRepository.Create(aeroplaneType);

            return mapper.Map<AeroplaneType, AeroplaneTypeDto>(resultAeroplaneType);
        }

        public AeroplaneTypeDto Update(Guid id, AeroplaneTypeDto aeroplaneTypeDto)
        {
            aeroplaneTypeDto.Id = id;
            var aeroplaneType = mapper.Map<AeroplaneTypeDto, AeroplaneType>(aeroplaneTypeDto);
            var resultAeroplaneType = db.AeroplaneTypeRepository.Update(aeroplaneType);

            return mapper.Map<AeroplaneType, AeroplaneTypeDto>(resultAeroplaneType);
        }

        public void Delete(Guid id)
        {
            db.AeroplaneTypeRepository.Delete(id);
        }

        public void DeleteAll()
        {
            db.AeroplaneTypeRepository.Delete();
        }
    }
}