using System;
using System.Collections.Generic;

namespace Airport.DAL.Interfaces
{
    public interface IRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();

        TEntity Get(Guid id);

        void Create(TEntity item);

        void Update(TEntity item);

        void Delete(Guid id);

        void Delete();
    }
}
