using System;
using System.Collections.Generic;
using AutoMapper;
using Airport.BLL.Interfaces;
using Airport.DAL.Interfaces;
using Airport.DAL.Models;
using Airport.Shared.DTO;


namespace Airport.BLL.Services
{
    public class StewardessService : IStewardessService
    {
        private IUnitOfWork db;
        private IMapper mapper;

        public StewardessService(IUnitOfWork uow, IMapper mapper)
        {
            this.db = uow;
            this.mapper = mapper;
        }


        public StewardessDto Get(Guid id)
        {
            return mapper.Map<Stewardess, StewardessDto>(db.StewardessRepositiry.Get(id));
        }

        public IEnumerable<StewardessDto> GetAll()
        {
            return mapper.Map<IEnumerable<Stewardess>, IEnumerable<StewardessDto>>(db.StewardessRepositiry.GetAll());
        }

        public StewardessDto Create(StewardessDto stewardessDto)
        {
            stewardessDto.Id = Guid.NewGuid();
            var stewardess = mapper.Map<StewardessDto, Stewardess>(stewardessDto);
            var resultStewardess = db.StewardessRepositiry.Create(stewardess);

            return mapper.Map<Stewardess, StewardessDto>(resultStewardess);
        }

        public StewardessDto Update(Guid id, StewardessDto stewardessDto)
        {
            stewardessDto.Id = id;
            var stewardess = mapper.Map<StewardessDto, Stewardess>(stewardessDto);
            var resultStewardess = db.StewardessRepositiry.Update(stewardess);

            return mapper.Map<Stewardess, StewardessDto>(resultStewardess);
        }

        public void Delete(Guid id)
        {
            db.StewardessRepositiry.Delete(id);
        }

        public void DeleteAll()
        {
            db.StewardessRepositiry.Delete();
        }
    }
}