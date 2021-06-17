using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Gamer
    {
        public long NationalityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DateOfBirthYear { get; set; }
    }
}
