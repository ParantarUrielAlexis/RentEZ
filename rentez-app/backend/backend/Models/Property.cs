using backend.Models;

public class Property {
    public int PropertyID { get; set; } // Primary Key
    public int UserID { get; set; } // Foreign Key to User
    public int FeatureID { get; set; } // Foreign Key to Feature
    public string Name { get; set; } = string.Empty;
    public string Street { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string Province { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }


    // Navigation property for the one-to-many relationship with Images
    public ICollection<Image> Images { get; set; } = new List<Image>();

    // Navigation property to Feature
    public Feature? Feature { get; set; }

    // Navigation property to User
    public User? User { get; set; }
}
