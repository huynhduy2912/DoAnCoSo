using System.ComponentModel.DataAnnotations;

namespace DoAnNhom11.Models
{
    public class CartItem
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public decimal Price { get; set; }
        public uint Quantity { get; set; }

    }
}
