namespace backend.DTO {
    public class ImageDTO {
        public int ImageID { get; set; }
        public int PropertyID { get; set; }
        public string ImageURL { get; set; } = string.Empty;
    }

    public class CreateImageDTO {
        // PropertyID is required to associate the image with a property
        public int PropertyID { get; set; }

        // ImageURL is required to store the URL of the image
        public string ImageURL { get; set; } = string.Empty;
    }
}
