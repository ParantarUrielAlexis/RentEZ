using backend.Data;
using backend.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace backend.Repository {
    public class PropertyRepository : IPropertyRepository {
        private readonly RentEZDbContext _context;

        public PropertyRepository(RentEZDbContext context) {
            _context = context;
        }

        public async Task<IEnumerable<Property>> GetAllAsync() {
            return await _context.Properties.ToListAsync();
        }

        public async Task<Property?> GetByIdAsync(int id) {
            return await _context.Properties.FindAsync(id);
        }

        public async Task AddAsync(Property property) {
            _context.Properties.Add(property);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Property property) {
            _context.Properties.Update(property);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id) {
            var property = await GetByIdAsync(id);
            if (property != null) {
                _context.Properties.Remove(property);
                await _context.SaveChangesAsync();
            }
        }
    }
}
