using FinalProject.Entities;
using FinalProject.Repositories;

namespace FinalProject.Services {
	public class PurchaseService : IPurchaseService{
		private readonly IPurchaseRepository _repo;
		public PurchaseService(IPurchaseRepository repo) {
			_repo = repo;
		}
		public async Task<IEnumerable<PurchaseHistory>> GetPurchaseHistory(int id) {
			return await _repo.GetHistory(id);
		}
		public async Task<PurchaseHistory> AddHistory(PurchaseHistory history) {
			return await _repo.Add(history);
		}
	}
}
