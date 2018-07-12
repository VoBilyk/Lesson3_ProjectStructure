using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        void SaveChanges();
    }
}
