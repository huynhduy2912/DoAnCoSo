namespace DoAnNhom11.Models
{
    public class ProductCategory
    {
        public int ProductCategoryId { get; set; }
        public string? TenLoai { get; set; } 
        public string? AnhDaiDien { get; set; }
        public virtual List<Product>? Products { get; set; }
    }
}
