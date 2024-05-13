namespace DoAnNhom11.Models
{
    public class ReviewsImage
    {
        public int ReviewsImageId { get; set; }
        public string Url{ get; set; }
        public int ReviewsId { get; set; }
        public Reviews? Reviews { get; set; }

    }
}
