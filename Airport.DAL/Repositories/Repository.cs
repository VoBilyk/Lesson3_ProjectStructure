using System;
using System.Collections.Generic;
using Airport.DAL.Interfaces;

namespace Airport.DAL.Repositories
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
            var foundedItem = db.Find(t => t.Id == id);

            if (foundedItem == null)
            {
                throw new ArgumentException("Id don`t exists");
            }

            return foundedItem;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return db;
        }

        public void Create(TEntity item)
        {
            var foundedItem = db.Find(i => i.Id == item.Id);

            if (foundedItem == null)
            {
                throw new ArgumentException("Item has alredy exist");
            }

            db.Add(item);
        }

        public void Update(TEntity item)
        {
            var foundedItem = db.Find(t => t.Id == item.Id);

            if (foundedItem != null)
            {
                db.Remove(foundedItem);
                db.Add(item);
            }
            else
            {
                throw new ArgumentException("Id don`t exists");
            }
        }

        public void Delete(Guid id)
        {
            var ticket = db.Find(item => item.Id == id);

            if (ticket == null)
            {
                throw new ArgumentException("Id don`t exists");
            }

            db.Remove(ticket);
        }

        public void Delete()
        {
            db.Clear();
        }
    }
}
