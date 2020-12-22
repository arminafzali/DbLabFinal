using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbLabFinal.Domain
{
    public class Product : BaseEntity
    {
        public String ProductName { get; set; }
        public String ProductDesc { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
