using FinalProject.Entities;

namespace FinalProject.Services {
	public interface IPurchaseService {
		public Task<IEnumerable<PurchaseHistory>> GetPurchaseHistory(int id);
		public Task<PurchaseHistory> AddHistory(PurchaseHistory history);
	}
}
