namespace backend.DTO {
    public class PropertyDTO {
        public int PropertyID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Province { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public decimal Bedroom { get; set; }
        public decimal Person { get; set; }
        public decimal Bathroom { get; set; }
        public string Type { get; set; } = string.Empty;
        public string Proximity { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
    }

    public class CreatePropertyDTO {
        public int UserID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Province { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public decimal Bedroom { get; set; }
        public decimal Person { get; set; }
        public decimal Bathroom { get; set; }
        public string Type { get; set; } = string.Empty;
        public string Proximity { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
    }
}
