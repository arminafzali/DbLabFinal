using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbLabFinal.Domain
{
    public class User :BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
