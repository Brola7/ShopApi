using FinalProject.DTOs;
using FinalProject.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Repositories {
	public class VCRepository : IVCRepository {
		private readonly ProjectContext _context;

		public VCRepository(ProjectContext context) {
			_context = context;
		}

		public async Task<IEnumerable<VideoCard>> GetVCs() {
			return await _context.VideoCards.ToListAsync();
		}
		public async Task<VideoCard> GetVC(int id) {
			return await _context.VideoCards.FindAsync(id);
		}
		public async Task<VideoCard> InsertVC(VideoCard vc) {
			var v = await _context.VideoCards.Where(VideoCard => VideoCard.Model == vc.Model).ToListAsync();
			if (v != null) {
				await _context.VideoCards.AddAsync(vc);
				await _context.SaveChangesAsync();
				return vc;
			}
			return null;
		}
		public async Task<VideoCard> UpdateVC(VideoCard vc) {
			_context.VideoCards.Update(vc);
			await _context.SaveChangesAsync();
			return vc;
		}
		public async Task DeleteVC(int id) {
			var vc = await _context.VideoCards.FindAsync(id);
			if (vc != null) {
				_context.VideoCards.Remove(vc);
				await _context.SaveChangesAsync();
			}
		}
	}
}
