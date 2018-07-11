using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.DAL.Interfaces
{
    public interface IUnityOfWork
    {
        void SaveChanges();
    }
}
