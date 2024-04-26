using System.ComponentModel.DataAnnotations;

namespace DoAnNhom11.Models
{
    public class Shop
    {
        public int ShopId { get; set; }
        public string TenCuaHang { get; set; }
        public string DiaChi { get; set; }
        public string LienHe { get; set; }
        public string AnhDaiDien { get; set; }
        public string AnhBia { get; set; }
        public DateTime NgayTao { get; set; }
        public string MoTa { get; set; }
        public int ShopCategoryId { get; set; }
        public ShopCategory? ShopCategories { get; set; }
        public List<Product>? Products { get; set; }
    }
}
