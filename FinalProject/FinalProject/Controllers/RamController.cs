using FinalProject.DTOs;
using FinalProject.Entities;
using FinalProject.Filters;
using FinalProject.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RamController : ControllerBase
    {

        private readonly IRamService _service;
        public RamController(IRamService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ram>>> GetAll()
        {
            var rams = await _service.GetAllRams();
            return Ok(rams);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Ram>> Get(int id)
        {
            var ram = await _service.GetRam(id);
            return Ok(ram);
        }

        [Authorize]
        [RoleFilter("Admin")]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Ram ram)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var Created = await _service.CreateRam(ram);
            return CreatedAtAction(nameof(Get), new { id = Created.Id }, Created);
        }

        [Authorize]
        [RoleFilter("User,Admin")]
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] PutDto dto)
        {
            var cpu = await _service.ChangeRam(dto.Id, dto.Stock);
            if (cpu == null)
            {
                return NotFound();
            }
            return Ok(cpu);
        }

        [Authorize]
        [RoleFilter("Admin")]
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _service.RemoveRam(id);
        }
    }
}
