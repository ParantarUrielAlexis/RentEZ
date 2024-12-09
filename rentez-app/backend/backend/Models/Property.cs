namespace backend.Models {
    public class Property {
        public int PropertyID { get; set; } // Primary Key
        public int UserID { get; set; } // Foreign Key (User)
        public int FeatureID { get; set; } // Foreign Key (Feature)
        public int ImageID { get; set; } // Foreign Key (Image)
        public string Name { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Province { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }

      
    }
}
