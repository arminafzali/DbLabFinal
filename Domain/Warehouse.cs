﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbLabFinal.Domain
{
    public class Warehouse : BaseEntity
    {
        public string Description { get; set; }
        public IList<WarehouseProduct> WarehouseProducts { get; set; }
    }
}
