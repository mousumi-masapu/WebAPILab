﻿using System;
using System.Collections.Generic;

namespace WebAPIEntityFW.Models
{
    public partial class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
