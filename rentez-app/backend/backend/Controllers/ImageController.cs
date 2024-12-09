using backend.Models;
using backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase {
        private readonly IImageService _service;

        public ImageController(IImageService service) {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() {
            var images = await _service.GetAllAsync();
            return Ok(images);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id) {
            var image = await _service.GetByIdAsync(id);
            if (image == null) return NotFound();
            return Ok(image);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Image image) {
            if (image == null) return BadRequest();
            var createdImage = await _service.CreateAsync(image);
            return CreatedAtAction(nameof(GetById), new { id = createdImage.ImageID }, createdImage);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Image image) {
            if (image == null || id != image.ImageID) return BadRequest();

            var success = await _service.UpdateAsync(id, image);
            if (!success) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) {
            var success = await _service.DeleteAsync(id);
            if (!success) return NotFound();
            return NoContent();
        }
    }
}
