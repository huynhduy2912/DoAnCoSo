using DoAnNhom11.Models;
using Microsoft.AspNetCore.Authorization;

namespace DoAnNhom11.Models
{
    
    public class ShoppingCart
    {
        //danh sách các sản phẩm trong giỏ hàng

        public List<CartItem> Items { get; set; } = new List<CartItem>();
        //phương thức: thêm/xóa/cập nhật số lượng SP trong giỏ hàng
        public void AddItem(CartItem item)
        {
            var existingItem = Items.FirstOrDefault(i => i.ProductId == item.ProductId);
            if (existingItem != null)//đã có trong giỏ hàng
            {
                existingItem.Quantity += item.Quantity;//cập nhật số lượng
            }
            else
            {
                Items.Add(item);//thêm 1 sản phẩm vào giỏ hàng
            }
        }
        public void RemoveItem(int productId)
        {
            Items.RemoveAll(i => i.ProductId == productId);//xóa 1 sản phẩm trong giỏ hàng
        }
        //hàm 
    }
}
