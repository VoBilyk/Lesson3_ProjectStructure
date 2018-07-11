using System;
using System.Collections.Generic;
using Airport.DAL.Interfaces;
using Airport.DAL.Models;

namespace Airport.DAL
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : IEntity
    {
        private readonly List<TEntity> db;

        public Repository(List<TEntity> context)
        {
            this.db = context;
        }

        public TEntity Get(Guid id)
        {
            return db.Find(t => t.Id == id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return db;
        }

        public void Create(TEntity item)
        {
            db.Add(item);
        }

        public void Update(TEntity item)
        {
            var ticket = db.Find(t => t.Id == item.Id);

            if (ticket != null)
            {
                db.Remove(ticket);
                db.Add(item);
            }
        }

        public void Delete(Guid id)
        {
            var ticket = db.Find(item => item.Id == id);
            db.Remove(ticket);
        }

        public void Delete()
        {
            db.Clear();
        }
    }
}
