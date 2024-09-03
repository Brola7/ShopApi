using FinalProject.DTOs;
using FinalProject.Entities;
using FinalProject.Filters;
using FinalProject.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers {
	[Route("api/[controller]")]
	[ApiController]
	public class VCController : ControllerBase {

		private readonly IVCService _service;
		public VCController(IVCService vcservice) {
			_service = vcservice;
		}
		[HttpGet]
        public async Task<ActionResult<IEnumerable<VideoCard>>> GetAll() {
            var vcs = await _service.GetAllVCs();
			return Ok(vcs);
		}

        [HttpGet("{id}")]
        public async Task<ActionResult<VideoCard>> Get(int id)
        {
            var vc = await _service.GetVC(id);
            return Ok(vc);
        }

        [Authorize]
        [RoleFilter("Admin")]
        [HttpPost]
		public async Task<IActionResult> Post([FromBody] VideoCard vc) {
			if (!ModelState.IsValid) {
				return BadRequest(ModelState);
			}

			var Created = await _service.CreateVC(vc);
			return CreatedAtAction(nameof(Get), new { id = Created.Id }, Created);
		}

        [Authorize]
        [RoleFilter("User,Admin")]
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] PutDto dto)
        {
            var cpu = await _service.ChangeVC(dto.Id, dto.Stock);
            if (cpu == null)
            {
                return NotFound();
            }
            return Ok(cpu);
        }

        [Authorize]
        [RoleFilter("Admin")]
        [HttpDelete("{id}")]
		public async Task Delete(int id) {
			await _service.RemoveVC(id);
		}
	}
}
