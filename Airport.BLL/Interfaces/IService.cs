using System;
using System.Collections.Generic;

namespace Airport.BLL.Interfaces
{
    public interface IService<TDto>
    {
        TDto Get(Guid? id);

        IEnumerable<TDto> GetAll();

        TDto Create(TDto dto);

        TDto Update(TDto dto);

        void Delete(Guid? id);

        void DeleteAll();
    }
}
