using System;
using System.Collections.Generic;

namespace Airport.DAL.Interfaces
{
    public interface IRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();

        TEntity Get(Guid id);

        TEntity Create(TEntity item);

        TEntity Update(TEntity item);

        void Delete(Guid id);

        void Delete();
    }
}
