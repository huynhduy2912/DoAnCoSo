using Microsoft.AspNetCore.Mvc;

namespace DoAnNhom11.Models
{
    public class VoucherCategory
    {
        public int VoucherCategoryId { get; set; }
        public string TenLoai { get; set; } = null!;
        public virtual ICollection<Voucher>? Vouchers { get; set; }
    }
}
