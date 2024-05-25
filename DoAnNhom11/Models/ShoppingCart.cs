using DoAnNhom11.Models;
using Microsoft.AspNetCore.Authorization;

namespace DoAnNhom11.Models
{
    
    public class ShoppingCart
    {

        public List<CartItem> Items { get; set; } = new List<CartItem>();
        public string shopName { get; set; }
        public int shopId { get; set; }
        public void AddItem(CartItem item)
        {
            var existingItem = Items.FirstOrDefault(i => i.ProductId == item.ProductId);
            if (existingItem != null)
            {
                existingItem.Quantity += item.Quantity;
            }
            else
            {
                Items.Add(item);
            }
        }
        public decimal TotalPrice()
            
        {
            decimal total = 0;
            foreach (var item in Items)
            {
                total += item.Price * item.Quantity;
            }
            return total;
        }
        public void RemoveItem(int productId)
        {
            Items.RemoveAll(i => i.ProductId == productId);//xóa 1 sản phẩm trong giỏ hàng
        }
        //hàm 
    }
}
