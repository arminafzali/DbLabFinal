using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbLabFinal.Domain
{
    public class WarehouseProduct : BaseEntity
    {
        public Warehouse Warehouse { get; set; }
        public Product Product { get; set; }
        public int ProductAmount { get; set; }
    }
}
