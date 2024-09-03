using AutoMapper;
using FinalProject.DTOs;
using FinalProject.Entities;
using FinalProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Services {
	public class CPUService : ICPUService {
		private readonly ICPURepository _cpurep;
        public CPUService(ICPURepository cpurep) {
			_cpurep = cpurep;
		}
		public async Task<IEnumerable<Cpu>> GetAllCpus() {
			return await _cpurep.GetCpus();
		}
		public async Task<Cpu> GetCpu(int id) {
			return await _cpurep.GetCpu(id);
		}
		public async Task<Cpu> CreateCpu(Cpu cpu) {
			return await _cpurep.InsertCpu(cpu);
		}
		public async Task<Cpu> ChangeCpu(int Id, int Stock)
        {
            var cpu = await _cpurep.GetCpu(Id);
            if (cpu != null)
            {
                if (cpu.Stock + Stock >= 0)
                {
                    cpu.Stock += Stock;
                    await _cpurep.UpdateCpu(cpu);
                    return cpu;
                }
                return null;
            }
            return null;
        }
		public async Task RemoveCpu(int id) {
			await _cpurep.DeleteCpu(id);
		}
	}
}
