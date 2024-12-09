using backend.Models;

namespace backend.Repository {
    public interface IImageRepository {
        Task<IEnumerable<Image>> GetAllAsync();
        Task<Image?> GetByIdAsync(int id);
        Task AddAsync(Image image);
        Task UpdateAsync(Image image);
        Task DeleteAsync(int id);
    }
}
