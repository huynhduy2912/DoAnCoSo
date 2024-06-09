using DoAnNhom11.Models;
using Microsoft.Identity.Client;

namespace DoAnNhom11.Services.VnPay
{
    public class VnPaymentResponseModel
    {
        public bool Success { get; set; }
        public string PaymentMethod { get; set; }
        public string OrderDescription { get; set; }
        public string OrderId { get; set; }
        public string PaymentId { get; set; }
        public string TransactionId { get; set; }
        public string Token { get; set; }
        public string VnPayResponseCode { get; set; }
    }

    public class VnPaymentRequestModel
    {
        public int OrderId { get; set; }
        public double Amount { get; set; }
        public DateTime CreatedDate { get; set; }
    }
    public class OrderSessionModel
    {
        public Order Order { get; set; }
        public int shopId { get; set; }
    }
}
