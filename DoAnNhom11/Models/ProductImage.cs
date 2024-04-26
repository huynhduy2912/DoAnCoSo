﻿using System.ComponentModel.DataAnnotations;

namespace DoAnNhom11.Models
{
    public class ProductImage
    {
        public int ProductImageId { get; set; }
        public string Url { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
