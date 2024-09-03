using FinalProject.Entities;

namespace FinalProject.Repositories {
	public interface IPurchaseRepository {
		public Task<IEnumerable<PurchaseHistory>> GetHistory(int userid);
		public Task<PurchaseHistory> Add(PurchaseHistory history);
	}
}
