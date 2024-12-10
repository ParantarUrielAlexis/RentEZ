using backend.Models;

public class Image {
    public int ImageID { get; set; } // Primary Key
    public int PropertyID { get; set; } // Foreign Key to Property  
    public string ImageURL { get; set; } = string.Empty;

    public Property? Property { get; set; }
}