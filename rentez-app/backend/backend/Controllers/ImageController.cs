using backend.Models;
using backend.Services;
using backend.DTO; // Import the DTO
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase {
        private readonly IImageService _service;

        public ImageController(IImageService service) {
            _service = service;
        }

        // Get all images
        [HttpGet]
        public async Task<IActionResult> GetAll() {
            var images = await _service.GetAllAsync();
            return Ok(images);
        }

        // Get image by ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id) {
            var image = await _service.GetByIdAsync(id);
            if (image == null) return NotFound();
            return Ok(image);
        }

        // Create a new image using CreateImageDTO
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateImageDTO createImageDTO) {
            if (createImageDTO == null) return BadRequest();

            // Map CreateImageDTO to Image model
            var image = new Image {
                PropertyID = createImageDTO.PropertyID,
                ImageURL = createImageDTO.ImageURL
            };

            var createdImage = await _service.CreateAsync(image);
            return CreatedAtAction(nameof(GetById), new { id = createdImage.ImageID }, createdImage);
        }

        // Update an existing image
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Image image) {
            if (image == null || id != image.ImageID) return BadRequest();

            var success = await _service.UpdateAsync(id, image);
            if (!success) return NotFound();
            return NoContent();
        }

        // Delete an image
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) {
            var success = await _service.DeleteAsync(id);
            if (!success) return NotFound();
            return NoContent();
        }
    }
}
