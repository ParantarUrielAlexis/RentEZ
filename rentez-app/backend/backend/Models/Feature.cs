namespace backend.Models {
    public class Feature {
        public int FeatureID { get; set; } // Primary Key
        public int Bedroom { get; set; }
        public int Capacity { get; set; }
        public string Type { get; set; } = string.Empty;
        public int Bathroom { get; set; }
        public string Proximity { get; set; } = string.Empty;
        public string GeneralPolicy { get; set; } = string.Empty;

        
    }
}
