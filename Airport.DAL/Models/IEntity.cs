using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.Repository.Models
{
    public interface IEntity
    {
        Guid Id { get; set; }
    }
}
