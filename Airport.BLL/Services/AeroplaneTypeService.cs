﻿using System;
using System.Collections.Generic;
using Airport.BLL.Interfaces;
using Airport.DAL.Interfaces;
using Airport.DAL.Models;
using Airport.Shared.DTO;
using AutoMapper;

namespace Airport.BLL.Services
{
    public class AeroplaneTypeService : IAeroplaneTypeService
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

        public List<AeroplaneTypeDto> GetAll()
        {
            return mapper.Map<List<AeroplaneType>, List<AeroplaneTypeDto>>(db.AeroplaneTypeRepository.GetAll());
        }

        public AeroplaneTypeDto Create(AeroplaneTypeDto aeroplaneTypeDto)
        {
            var aeroplaneType = mapper.Map<AeroplaneTypeDto, AeroplaneType>(aeroplaneTypeDto);
            aeroplaneType.Id = Guid.NewGuid();

            return mapper.Map<AeroplaneType, AeroplaneTypeDto>(db.AeroplaneTypeRepository.Create(aeroplaneType));
        }

        public AeroplaneTypeDto Update(Guid id, AeroplaneTypeDto aeroplaneTypeDto)
        {
            var aeroplaneType = mapper.Map<AeroplaneTypeDto, AeroplaneType>(aeroplaneTypeDto);
            aeroplaneType.Id = id;

            return mapper.Map<AeroplaneType, AeroplaneTypeDto>(db.AeroplaneTypeRepository.Update(aeroplaneType));
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