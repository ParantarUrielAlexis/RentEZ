﻿using backend.Models;

namespace backend.Repository {
    public interface IPropertyRepository {
        Task<IEnumerable<Property>> GetAllAsync();
        Task<Property?> GetByIdAsync(int id);
        Task AddAsync(Property property);
        Task UpdateAsync(Property property);
        Task DeleteAsync(int id);
    }
}
