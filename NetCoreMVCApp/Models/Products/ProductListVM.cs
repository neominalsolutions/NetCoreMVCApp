﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMVCApp.Models.Products
{
    public class ProductListVM
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public short Stock { get; set; }
    }
}
