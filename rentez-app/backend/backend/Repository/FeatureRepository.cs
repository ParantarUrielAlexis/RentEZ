using backend.Data;
using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Repository {
    public class FeatureRepository : IFeatureRepository {
        private readonly RentEZDbContext _context;

        public FeatureRepository(RentEZDbContext context) {
            _context = context;
        }

        public async Task<List<Feature>> GetAllFeatures() {
            return await _context.Features.ToListAsync();
        }

        public async Task<Feature> GetFeatureById(int id) {
            return await _context.Features.FirstOrDefaultAsync(f => f.FeatureID == id);
        }

        public async Task<Feature> AddFeature(Feature feature) {
            _context.Features.Add(feature);
            await _context.SaveChangesAsync();
            return feature;
        }

        public async Task<bool> UpdateFeature(Feature feature) {
            _context.Features.Update(feature);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteFeature(int id) {
            var feature = await _context.Features.FirstOrDefaultAsync(f => f.FeatureID == id);
            if (feature != null) {
                _context.Features.Remove(feature);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
