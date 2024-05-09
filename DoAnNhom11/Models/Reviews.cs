using System.ComponentModel.DataAnnotations;

namespace DoAnNhom11.Models
{
    public class Reviews
    {
        public int ReviewsId { get; set; }
        public string NoiDung { get; set; }
        [Range(0, 5, ErrorMessage = "Giá trị từ 0-5")]
        public int? DiemDanhGia { get; set; }

        public DateTime ThoiGianDanhGia { get; set; }

        public string CustomerId { get; set; }
        public ApplicationUser? Customer { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        public List<ReviewsImage>? ReviewsImages { get; set; }


    }
}
