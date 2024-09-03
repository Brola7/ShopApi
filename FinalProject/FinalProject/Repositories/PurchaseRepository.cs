using FinalProject.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Repositories {
	public class PurchaseRepository : IPurchaseRepository{
		private readonly ProjectContext _context;

		public PurchaseRepository(ProjectContext context) {
			_context = context;
		}
		public async Task<IEnumerable<PurchaseHistory>> GetHistory(int userid) {
			return await _context.PurchaseHistories.Where(PurchaseHistory => PurchaseHistory.UserId == userid).ToListAsync();
		}
		public async Task<PurchaseHistory> Add(PurchaseHistory history) {
			await _context.PurchaseHistories.AddAsync(history);
			await _context.SaveChangesAsync();
			return history;
		}
	}
}
