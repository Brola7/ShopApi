using FinalProject.DTOs;
using FinalProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Services {
	public interface IRamService {
		Task<IEnumerable<Ram>> GetAllRams();
		Task<Ram> GetRam(int id);
		Task<Ram> CreateRam(Ram ram);
		Task<Ram> ChangeRam(int Id, int Stock);
		Task RemoveRam(int id);
	}
}
