﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.Models
{
    //inherits from BaseEntity.cs BaseEntity public class.
    public class ProductCategory : BaseEntity
    {
        public string Category { get; set; }
    }
}
