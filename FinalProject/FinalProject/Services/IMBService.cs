using FinalProject.DTOs;
using FinalProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Services {
	public interface IMBService {
		Task<IEnumerable<MotherBoard>> GetAllMBs();
		Task<MotherBoard> GetMB(int id);

		Task<MotherBoard> CreateMB(MotherBoard mb);
		Task<MotherBoard> ChangeMB(int Id, int Stock);
		Task RemoveMB(int id);
	}
}
