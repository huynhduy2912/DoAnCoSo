using System.ComponentModel.DataAnnotations;

namespace DoAnNhom11.Models
{
    public class ShopCategory
    {
        public int ShopCategoryId { get; set; }
        public string TenLoai { get; set; }
        public List<Shop>? Shops { get; set; }

    }
}
