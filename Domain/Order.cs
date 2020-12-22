using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbLabFinal.Domain
{
    public class Order : BaseEntity
    {
        public User User { get; set; }
        public Delivery Delivery { get; set; }
        public Warehouse Warehouse { get; set; }
        public IList<OrderItem> Items { get; set; }
        public Status Status { get; set; }
        public double TotalPrice { get; set; }
    }
    public enum Status
    {
        Pending = 0,
        Done = 1,
        Reject = -1
    }
}
