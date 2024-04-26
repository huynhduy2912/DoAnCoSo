namespace DoAnNhom11.Models
{
    public class OrderStatus
    {
        public int OrderStatusId { get; set; }
        public string TenTrangThai { get; set; } = null!;
        public List<Order>? Orders { get; set; }


    }
}
