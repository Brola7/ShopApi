using FinalProject.DTOs;
using FinalProject.Entities;
using FinalProject.Filters;
using FinalProject.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MBController : ControllerBase
    {

        private readonly IMBService _service;
        public MBController(IMBService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MotherBoard>>> GetAll()
        {
            var mbs = await _service.GetAllMBs();
            return Ok(mbs);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MotherBoard>> Get(int id)
        {
            var mb = await _service.GetMB(id);
            return Ok(mb);
        }

        [HttpPost]
        [Authorize]
        [RoleFilter("Admin")]
        public async Task<IActionResult> Post([FromBody] MotherBoard mb)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var Created = await _service.CreateMB(mb);
            return CreatedAtAction(nameof(Get), new { id = Created.Id }, Created);
        }

        [HttpPut]
        [Authorize]
        [RoleFilter("User,Admin")]
        public async Task<IActionResult> Put([FromBody] PutDto dto)
        {
            var cpu = await _service.ChangeMB(dto.Id, dto.Stock);
            if (cpu == null)
            {
                return NotFound();
            }
            return Ok(cpu);
        }

        [HttpDelete("{id}")]
        [Authorize]
        [RoleFilter("Admin")]
        public async Task Delete(int id)
        {
            await _service.RemoveMB(id);
        }
    }
}
