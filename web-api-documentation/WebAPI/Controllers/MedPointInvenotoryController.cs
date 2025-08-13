using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    public class MedPointInvenotoryController : Controller
    {
        private readonly IMedPointInventoryService _medPointInventoryService;
        public MedPointInvenotoryController(IMedPointInventoryService medPointInventoryService)
        {
            _medPointInventoryService = medPointInventoryService ?? throw new ArgumentNullException(nameof(medPointInventoryService));
        }

        [HttpGet("medcases")]
        public IActionResult GetMedCases()
        {
            try
            {
                var data = _medPointInventoryService.GetData();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost("medcases")]
        public IActionResult CreateMedCase([FromBody] MedCase medCase)
        {
            if (medCase == null)
            {
                return BadRequest("MedCase cannot be null");
            }
            try
            {
                var result = _medPointInventoryService.CreateMedCase(medCase);
                if (result)
                {
                    return CreatedAtAction(nameof(GetMedCases), new { id = medCase.MedCaseKey }, medCase);
                }
                return BadRequest("Failed to create MedCase");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPut("medcases")]
        public IActionResult UpdateMedCase([FromBody] MedCase medCase)
        {
            if (medCase == null)
            {
                return BadRequest("MedCase cannot be null");
            }
            try
            {
                var result = _medPointInventoryService.UpdateMedCase(medCase);
                if (result)
                {
                    return NoContent(); // 204 No Content
                }
                return BadRequest("Failed to update MedCase");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpDelete("medcases/{medCaseKey}")]
        public IActionResult DeleteMedCase(Guid medCaseKey)
        {
            try
            {
                var result = _medPointInventoryService.DeleteMedCase(medCaseKey);
                if (result)
                {
                    return NoContent(); // 204 No Content
                }
                return NotFound("MedCase not found");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
