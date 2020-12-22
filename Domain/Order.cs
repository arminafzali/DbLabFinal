using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbLabFinal.Domain
{
    public class Order : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }

    }
}
