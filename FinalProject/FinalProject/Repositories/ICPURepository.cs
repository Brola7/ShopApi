using FinalProject.DTOs;
using FinalProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Repositories {
	public interface ICPURepository {
		Task<IEnumerable<Cpu>> GetCpus();
		Task<Cpu> GetCpu(int id);
		Task<Cpu> InsertCpu(Cpu cpu);
		Task<Cpu> UpdateCpu(Cpu cpu);
		Task DeleteCpu(int id);
	}
}
