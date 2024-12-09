using backend.Services;
using backend.DTO;
using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureController : ControllerBase {
        private readonly IFeatureService _featureService;

        public FeatureController(IFeatureService featureService) {
            _featureService = featureService;
        }

        // GET: api/Feature
        [HttpGet]
        public async Task<IActionResult> GetFeatures() {
            var features = await _featureService.GetAllFeatures();
            return Ok(features);
        }

        // GET: api/Feature/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFeature(int id) {
            var feature = await _featureService.GetFeatureById(id);
            if (feature == null) {
                return NotFound();
            }
            return Ok(feature);
        }

        // POST: api/Feature
        [HttpPost]
        public async Task<IActionResult> PostFeature([FromBody] FeatureDTO featureDTO) {
            if (featureDTO == null) {
                return BadRequest();
            }

            var feature = new Feature {
                Bedroom = featureDTO.Bedroom,
                Capacity = featureDTO.Capacity,
                Type = featureDTO.Type,
                Bathroom = featureDTO.Bathroom,
                Proximity = featureDTO.Proximity,
                GeneralPolicy = featureDTO.GeneralPolicy
            };

            var createdFeature = await _featureService.CreateFeature(feature);
            return CreatedAtAction(nameof(GetFeature), new { id = createdFeature.FeatureID }, createdFeature);
        }

        // PUT: api/Feature/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFeature(int id, [FromBody] Feature feature) {
            if (id != feature.FeatureID) {
                return BadRequest();
            }

            var updated = await _featureService.UpdateFeature(id, feature);
            if (!updated) {
                return NotFound();
            }

            return NoContent();
        }

        // DELETE: api/Feature/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFeature(int id) {
            var deleted = await _featureService.DeleteFeature(id);
            if (!deleted) {
                return NotFound();
            }

            return NoContent();
        }
    }
}
