using System;
using System.Collections.Generic;

namespace Airport.BLL.Interfaces
{
    public interface IService<TDto>
    {
        TDto Get(Guid id);

        List<TDto> GetAll();

        void Create(TDto dto);

        void Update(Guid id, TDto dto);

        void Delete(Guid id);

        void DeleteAll();
    }
}
