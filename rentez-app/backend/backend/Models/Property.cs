using backend.Models;

public class Property {
    public int PropertyID { get; set; } // Primary Key
    public int UserID { get; set; } // Foreign Key to User
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




    // Navigation property to User
    public User? User { get; set; }
}
