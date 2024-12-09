using backend.Data;
using backend.Models;
using Microsoft.EntityFrameworkCore;


namespace backend.Repository {
    public class ImageRepository : IImageRepository {
        private readonly RentEZDbContext _context;

        public ImageRepository(RentEZDbContext context) {
            _context = context;
        }

        public async Task<IEnumerable<Image>> GetAllAsync() {
            return await _context.Images.ToListAsync();
        }

        public async Task<Image?> GetByIdAsync(int id) {
            return await _context.Images.FindAsync(id);
        }

        public async Task AddAsync(Image image) {
            _context.Images.Add(image);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Image image) {
            _context.Images.Update(image);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id) {
            var image = await GetByIdAsync(id);
            if (image != null) {
                _context.Images.Remove(image);
                await _context.SaveChangesAsync();
            }
        }
    }
}
