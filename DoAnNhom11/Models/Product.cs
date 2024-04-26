namespace DoAnNhom11.Models
{
    public class Product
    {
        public required int ProductId { get; set; }
        public required string TenSp { get; set; }
        public string? AnhDaiDien { get; set; }
        public string? MoTa { get; set; }
        public string? ThongSo { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal GiaBan { get; set; }
        public int SoLuongCon { get; set; }
        public int? PhanTramGiam { get; set; }
        public int? DiemDanhGia { get; set; }
        public int ProductCategoryId { get; set; }

        public ProductCategory? ProductCategory { get; set; }
        public int BrandId { get; set; }
        public Brand? Brand { get; set; }
        public int ShopId { get; set; }
        public Shop? Shop { get; set; }
        public List<ProductImage>? Images { get; set; }
        public List<OrderDetail>? OrderDetails { get; set; }
        public List<Reviews>? ProductReviews { get; set; }
    }
}
