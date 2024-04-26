using System.ComponentModel.DataAnnotations;

namespace DoAnNhom11.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public string TenLoai { get; set; }
        public List<Order>? Orders { get; set; }

    }
}
