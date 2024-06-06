namespace DoAnNhom11.Models
{

    public class Province
    {
        public string _id { get; set; }

        public string name_with_type { get; set; }
        public string code { get; set; }
    }

    public class District
    {
        public string _id { get; set; }
        public string name_with_type { get; set; }

        public string code { get; set; }
        public string parent_code { get; set; }
    }

    public class Ward
    {
        public string _id { get; set; }
        public string name_with_type { get; set; }
        public string path_with_type { get; set; }

        public string code { get; set; }
        public string parent_code { get; set; }
    }
}
