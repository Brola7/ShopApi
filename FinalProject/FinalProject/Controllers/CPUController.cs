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
    public class CPUController : ControllerBase
    {

        private readonly ICPUService _service;
        public CPUController(ICPUService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cpu>>> GetAll()
        {
            var cpus = await _service.GetAllCpus();
            return Ok(cpus);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Cpu>> Get(int id)
        {
            var cpu = await _service.GetCpu(id);
            return Ok(cpu);
        }

        [HttpPost]
        [Authorize]
        [RoleFilter("Admin")]
        public async Task<IActionResult> Post([FromBody] Cpu cpu)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var Created = await _service.CreateCpu(cpu);
            return Ok(cpu);
        }

        [HttpPut]
        [Authorize]
        [RoleFilter("User,Admin")]
        public async Task<IActionResult> Put([FromBody] PutDto dto)
        {
            var cpu = await _service.ChangeCpu(dto.Id, dto.Stock);
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
            await _service.RemoveCpu(id);
        }
    }
}
