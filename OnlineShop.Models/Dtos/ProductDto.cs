﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Models.Dtos
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
