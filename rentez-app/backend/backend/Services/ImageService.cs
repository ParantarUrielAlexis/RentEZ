using backend.Models;
using backend.Repository;

namespace backend.Services {
    public class ImageService : IImageService {
        private readonly IImageRepository _repository;

        public ImageService(IImageRepository repository) {
            _repository = repository;
        }

        public async Task<IEnumerable<Image>> GetAllAsync() {
            return await _repository.GetAllAsync();
        }

        public async Task<Image?> GetByIdAsync(int id) {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<Image> CreateAsync(Image image) {
            await _repository.AddAsync(image);
            return image;
        }

        public async Task<bool> UpdateAsync(int id, Image image) {
            var existingImage = await _repository.GetByIdAsync(id);
            if (existingImage == null) return false;

            existingImage.ImageURL = image.ImageURL;
            existingImage.PropertyID = image.PropertyID;

            await _repository.UpdateAsync(existingImage);
            return true;
        }

        public async Task<bool> DeleteAsync(int id) {
            var image = await _repository.GetByIdAsync(id);
            if (image == null) return false;

            await _repository.DeleteAsync(id);
            return true;
        }
    }
}
