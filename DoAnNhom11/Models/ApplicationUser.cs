using Microsoft.AspNetCore.Identity;
using static NuGet.Packaging.PackagingConstants;

namespace DoAnNhom11.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public string? Avatar { get; set; }
        public int? ShopId { get; set; }
        public Shop? MyShop { get; set; }
        public List<Order>? Oders { get; set; }

    }
}
