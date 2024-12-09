using backend.Models;

namespace backend.Services {
    public interface IFeatureService {
        Task<List<Feature>> GetAllFeatures();
        Task<Feature> GetFeatureById(int id);
        Task<Feature> CreateFeature(Feature feature);
        Task<bool> UpdateFeature(int id, Feature feature);
        Task<bool> DeleteFeature(int id);
    }
}
