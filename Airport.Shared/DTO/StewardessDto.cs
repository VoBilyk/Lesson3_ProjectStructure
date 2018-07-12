using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.DTO
{
    public class StewardessDto
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public DateTime BirthDate { get; set; }
    }
}
