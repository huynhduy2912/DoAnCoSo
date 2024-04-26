namespace DoAnNhom11.Models
{
    public class Brand
    {
        public int BrandId { get; set; }
        public string TenNhanHieu { get; set; }
        public virtual ICollection<Product>? Products { get; set; }

    }
}
