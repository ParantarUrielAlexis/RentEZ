namespace backend.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        // Navigation property for the one-to-many relationship
        public ICollection<Property> Properties { get; set; } = new List<Property>();


    }
}
