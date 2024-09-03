using FinalProject.DTOs;
using FinalProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Repositories {
	public interface IMBRepository {
		Task<IEnumerable<MotherBoard>> GetMBs();
		Task<MotherBoard> GetMB(int id);
		Task<MotherBoard> InsertMB(MotherBoard mb);
		Task<MotherBoard> UpdateMB(MotherBoard mb);
		Task DeleteMB(int id);
	}
}
