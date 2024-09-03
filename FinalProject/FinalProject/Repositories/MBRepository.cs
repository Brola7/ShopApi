using FinalProject.DTOs;
using FinalProject.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Repositories {
	public class MBRepository : IMBRepository {
		private readonly ProjectContext _context;

		public MBRepository(ProjectContext context) {
			_context = context;
		}

		public async Task<IEnumerable<MotherBoard>> GetMBs() {
			return await _context.MotherBoards.ToListAsync();
		}
		public async Task<MotherBoard> GetMB(int id) {
			return await _context.MotherBoards.FindAsync(id);
		}
		public async Task<MotherBoard> InsertMB(MotherBoard mb) {
			var m = await _context.MotherBoards.Where(MotherBoard => MotherBoard.Model == mb.Model).ToListAsync();
			if (m != null) {
				await _context.MotherBoards.AddAsync(mb);
				await _context.SaveChangesAsync();
				return mb;
			}
			return null;
		}
		public async Task<MotherBoard> UpdateMB(MotherBoard mb) {
			_context.MotherBoards.Update(mb);
			await _context.SaveChangesAsync();
			return mb;
		}
		public async Task DeleteMB(int id) {
            var mb = await _context.MotherBoards.FindAsync(id);
			if (mb != null)
			{
				_context.MotherBoards.Remove(mb);
				await _context.SaveChangesAsync();
			}

		}
	}
}
