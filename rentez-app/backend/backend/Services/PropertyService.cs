using backend.DTO;
using backend.Models;
using backend.Repository;
using System;

namespace backend.Services {
    public class PropertyService : IPropertyService {
        private readonly IPropertyRepository _repository;

        public PropertyService(IPropertyRepository repository) {
            _repository = repository;
        }

        public async Task<IEnumerable<PropertyDTO>> GetAllAsync() {
            var properties = await _repository.GetAllAsync();
            return properties.Select(p => new PropertyDTO {
                PropertyID = p.PropertyID,
                Name = p.Name,
                Street = p.Street,
                City = p.City,
                Province = p.Province,
                Description = p.Description,
                Price = p.Price,
                Bedroom = p.Bedroom,
                Person = p.Person,
                Bathroom = p.Bathroom,
                Type = p.Type,
                Proximity = p.Proximity,
            });
        }

        public async Task<PropertyDTO?> GetByIdAsync(int id) {
            var property = await _repository.GetByIdAsync(id);
            return property == null ? null : new PropertyDTO {
                PropertyID = property.PropertyID,
                Name = property.Name,
                Street = property.Street,
                City = property.City,
                Province = property.Province,
                Description = property.Description,
                Price = property.Price,
                Bedroom = property.Bedroom,
                Person = property.Person,
                Bathroom = property.Bathroom,
                Type = property.Type,
                Proximity = property.Proximity,
            };
        }

        public async Task CreateAsync(CreatePropertyDTO dto) {
            var property = new Property {
                UserID = dto.UserID,
                Name = dto.Name,
                Street = dto.Street,
                City = dto.City,
                Province = dto.Province,
                Description = dto.Description,
                Price = dto.Price,
                Bedroom = dto.Bedroom,
                Person = dto.Person,
                Bathroom = dto.Bathroom,
                Type = dto.Type,
                Proximity = dto.Proximity,
            };
            await _repository.AddAsync(property);
        }

        public async Task UpdateAsync(int id, CreatePropertyDTO dto) {
            var property = await _repository.GetByIdAsync(id);
            if (property == null) return;

            property.UserID = dto.UserID;
            property.Name = dto.Name;
            property.Street = dto.Street;
            property.City = dto.City;
            property.Province = dto.Province;
            property.Description = dto.Description;
            property.Price = dto.Price;
            property.Bedroom = dto.Bedroom;
            property.Person = dto.Person;
            property.Bathroom = dto.Bathroom;
            property.Type = dto.Type;
            property.Proximity = dto.Proximity;

            await _repository.UpdateAsync(property);
        }

        public async Task DeleteAsync(int id) {
            await _repository.DeleteAsync(id);
        }
    }
}
