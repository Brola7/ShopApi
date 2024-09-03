using FinalProject.DTOs;
using FinalProject.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Repositories {
	public class RamRepository : IRamRepository {

		private readonly ProjectContext _context;

		public RamRepository(ProjectContext context) {
			_context = context;
		}

		public async Task<IEnumerable<Ram>> GetRams() {
			return await _context.Rams.ToListAsync();
		}
		public async Task<Ram> GetRam(int id) {
			return await _context.Rams.FindAsync(id);
		}
		public async Task<Ram> InsertRam(Ram ram) {
			var r = await _context.Rams.Where(Ram => Ram.Model == ram.Model).ToListAsync();
			if (r != null) {
				await _context.Rams.AddAsync(ram);
				await _context.SaveChangesAsync();
				return ram;
			}
			return null;
		}
		public async Task<Ram> UpdateRam(Ram ram) {
			_context.Rams.Update(ram);
			await _context.SaveChangesAsync();
			return ram;
		}
		public async Task DeleteRam(int id) {
            var ram = await _context.Rams.FindAsync(id);
            if (ram != null)
            {
                _context.Rams.Remove(ram);
                await _context.SaveChangesAsync();
            }
        }
	}
}
