using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbLabFinal.Domain
{
    public class OrderItem : BaseEntity
    {
        public Order Order { get; set; }
        public Product Product { get; set; }
        public int ProductAmount { get; set; }
    }
}
