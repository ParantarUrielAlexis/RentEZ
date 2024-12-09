using backend.DTO;
using backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class PropertyController : ControllerBase {
        private readonly IPropertyService _service;

        public PropertyController(IPropertyService service) {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() {
            var properties = await _service.GetAllAsync();
            return Ok(properties);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id) {
            var property = await _service.GetByIdAsync(id);
            return property == null ? NotFound() : Ok(property);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreatePropertyDTO dto) {
            await _service.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = dto }, dto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] CreatePropertyDTO dto) {
            await _service.UpdateAsync(id, dto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) {
            await _service.DeleteAsync(id);
            return NoContent();
        }
    }
}
