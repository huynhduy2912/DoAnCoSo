namespace DoAnNhom11.Models
{
    public class Voucher
    {
        public int VoucherId { get; set; }
        public string VoucherCode { get; set; }
        public int PhanTramGiam { get; set; }
        public decimal? GiamToiDa { get; set; }
        public decimal? DonToiThieu { get; set; }
        public DateTime NgayHetHan { get; set; }
        public int SoLuongCon { get; set; }
        public List<Order>? Orders { get; set; }
        public int VoucherCategoryId { get; set; }
        public VoucherCategory? VoucherCategory { get; set; }
        public int? ShopId { get; set; }
        public Shop? Shop { get; set; }
    }
}
