using backend.DTO;

namespace backend.Services {
    public interface IPropertyService {
        Task<IEnumerable<PropertyDTO>> GetAllAsync();
        Task<PropertyDTO?> GetByIdAsync(int id);
        Task CreateAsync(CreatePropertyDTO dto);
        Task UpdateAsync(int id, CreatePropertyDTO dto);
        Task DeleteAsync(int id);
    }
}
