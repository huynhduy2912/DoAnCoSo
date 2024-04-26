using System.ComponentModel.DataAnnotations;

namespace DoAnNhom11.Models
{
    public class Reviews
    {
        public int ReviewsId { get; set; }
        public string NoiDung { get; set; }
        public int? DiemDanhGia { get; set; }

        public DateTime ThoiGianDanhGia { get; set; }

        public int CustomerId { get; set; }
        public ApplicationUser? Customer { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        public List<ReviewsImage>? ReviewsImages { get; set; }


    }
}
