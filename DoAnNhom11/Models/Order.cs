using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAnNhom11.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public string? ShippingAddress { get; set; }
        public string? Notes { get; set; }
        public int? VoucherId { get; set; }
        public Voucher? VouCher { get; set; }
        public int? PaymentId { get; set; }
        public Payment? Payment { get; set; }
        public int? OrderStatusId { get; set; }
        public OrderStatus? OrderStatus { get; set; }
        [ForeignKey("UserId")]
        [ValidateNever]
        public ApplicationUser? ApplicationUser { get; set; }
        public string UserId { get; set; }
        

        public List<OrderDetail>? OrderDetails { get; set; }
    }
}
