using FinalProject.DTOs;
using FinalProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Services {
	public interface ICPUService {
		Task<IEnumerable<Cpu>> GetAllCpus();
		Task<Cpu> GetCpu(int id);
		Task<Cpu> CreateCpu(Cpu cpu);
		Task<Cpu> ChangeCpu(int Id, int Stock);
		Task RemoveCpu(int id);
	}
}
