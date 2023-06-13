﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Models.Dtos
{
    public class CartItemDto
    {
        public int Id { get; set; }

        public int ProductId { get; set; }
        public int CartId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int ProductImageURL { get; set;}
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set;}
        public int Quantity { get; set; }
    }
}
