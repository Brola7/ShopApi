using FinalProject.Entities;
using FinalProject.Filters;
using FinalProject.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseController : ControllerBase
    {
        private readonly IPurchaseService _purchaseService;

        public PurchaseController(IPurchaseService purchaseService)
        {
            _purchaseService = purchaseService;
        }

        [HttpGet("{id}")]
        [Authorize]
        [RoleFilter("User,Admin")]
        public async Task<ActionResult<IEnumerable<PurchaseHistory>>> GetPurchaseHistory(int id)
        {
            var history = await _purchaseService.GetPurchaseHistory(id);
            return Ok(history);
        }

        [HttpPost]
        [Authorize]
        [RoleFilter("User,Admin")]
        public async Task<IActionResult> AddPurchaseHistory([FromBody] PurchaseHistory history)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var addedHistory = await _purchaseService.AddHistory(history);

                return Ok(addedHistory);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
