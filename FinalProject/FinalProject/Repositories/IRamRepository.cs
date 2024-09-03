using FinalProject.DTOs;
using FinalProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Repositories {
	public interface IRamRepository {
		Task<IEnumerable<Ram>> GetRams();
		Task<Ram> GetRam(int id);
		Task<Ram> InsertRam(Ram ram);
		Task<Ram> UpdateRam(Ram ram);
		Task DeleteRam(int id);
	}
}
