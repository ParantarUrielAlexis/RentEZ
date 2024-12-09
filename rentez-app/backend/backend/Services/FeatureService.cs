using backend.Data;
using backend.Models;
using Microsoft.EntityFrameworkCore;


namespace backend.Services {
    public class FeatureService : IFeatureService {
        private readonly RentEZDbContext _context;

        public FeatureService(RentEZDbContext context) {
            _context = context;
        }

        public async Task<List<Feature>> GetAllFeatures() {
            return await _context.Features.ToListAsync();
        }

        public async Task<Feature> GetFeatureById(int id) {
            return await _context.Features.FirstOrDefaultAsync(f => f.FeatureID == id);
        }

        public async Task<Feature> CreateFeature(Feature feature) {
            _context.Features.Add(feature);
            await _context.SaveChangesAsync();
            return feature;
        }

        public async Task<bool> UpdateFeature(int id, Feature feature) {
            var existingFeature = await _context.Features.FirstOrDefaultAsync(f => f.FeatureID == id);
            if (existingFeature == null) return false;

            existingFeature.Bedroom = feature.Bedroom;
            existingFeature.Capacity = feature.Capacity;
            existingFeature.Type = feature.Type;
            existingFeature.Bathroom = feature.Bathroom;
            existingFeature.Proximity = feature.Proximity;
            existingFeature.GeneralPolicy = feature.GeneralPolicy;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteFeature(int id) {
            var feature = await _context.Features.FirstOrDefaultAsync(f => f.FeatureID == id);
            if (feature == null) return false;

            _context.Features.Remove(feature);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
