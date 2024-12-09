using backend.Models;
public class Feature {
    public int FeatureID { get; set; } // Primary Key
    public int Bedrooms { get; set; }
    public int Capacity { get; set; }
    public int Bathrooms { get; set; }
    public string Type { get; set; } = string.Empty; // e.g., "Apartment", "House"
    public string Proximity { get; set; } = string.Empty; // e.g., "Near School"
    public string GeneralPolicy { get; set; } = string.Empty;

    // Navigation property for the one-to-many relationship
    public ICollection<Property> Properties { get; set; } = new List<Property>();
}
