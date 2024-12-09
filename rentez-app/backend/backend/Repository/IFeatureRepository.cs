using backend.Models;

namespace backend.Repository {
    public interface IFeatureRepository {
        Task<List<Feature>> GetAllFeatures();
        Task<Feature> GetFeatureById(int id);
        Task<Feature> AddFeature(Feature feature);
        Task<bool> UpdateFeature(Feature feature);
        Task<bool> DeleteFeature(int id);
    }
}
