using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbLabFinal.Domain
{
    public class Delivery : User
    {
        public IList<Order> Order { get; set; }
        public double Credit { get; set; }
    }
}
