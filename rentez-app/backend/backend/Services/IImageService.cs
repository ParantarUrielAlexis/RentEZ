using backend.Models;

namespace backend.Services {
    public interface IImageService {
        Task<IEnumerable<Image>> GetAllAsync();
        Task<Image?> GetByIdAsync(int id);
        Task<Image> CreateAsync(Image image);
        Task<bool> UpdateAsync(int id, Image image);
        Task<bool> DeleteAsync(int id);
    }
}
