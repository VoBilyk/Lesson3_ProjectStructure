using System;
using System.Collections.Generic;

namespace Airport.BLL.Interfaces
{
    public interface IService<TDto>
    {
        TDto Get(Guid? id);

        IEnumerable<TDto> GetAll();

        void Create(TDto dto);

        void Update(TDto dto);

        void Delete(Guid? id);

        void DeleteAll();
    }
}
