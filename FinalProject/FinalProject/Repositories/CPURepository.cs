using FinalProject.DTOs;
using FinalProject.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Repositories {
	public class CPURepository : ICPURepository {
		private readonly ProjectContext _context;

		public CPURepository(ProjectContext context) {
			_context = context;
		}

		public async Task<IEnumerable<Cpu>> GetCpus() {
			return await _context.Cpus.ToListAsync();
		}
		public async Task<Cpu> GetCpu(int id) {
			return await _context.Cpus.FindAsync(id);
		}
		public async Task<Cpu> InsertCpu(Cpu cpu) {
			var c = await _context.Cpus.Where(Cpu => Cpu.Model == cpu.Model).ToListAsync();
			if(c != null) {
				await _context.Cpus.AddAsync(cpu);
				await _context.SaveChangesAsync();
				return cpu;
			}
			return null;
		}
        public async Task<Cpu> UpdateCpu(Cpu cpu)
        {
            _context.Cpus.Update(cpu);
            await _context.SaveChangesAsync();
            return cpu;
        }

        public async Task DeleteCpu(int id) {
            var cpu = await _context.Cpus.FindAsync(id);
            if (cpu != null)
            {
                _context.Cpus.Remove(cpu);
                await _context.SaveChangesAsync();
            }
        }
	}
}
