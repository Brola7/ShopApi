using FinalProject.DTOs;
using FinalProject.Entities;
using FinalProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Services {
	public class RamService : IRamService {
		private readonly IRamRepository _ramrep;
		public RamService(IRamRepository ramrep) {
			_ramrep = ramrep;
		}
		public async Task<IEnumerable<Ram>> GetAllRams() {
			return await _ramrep.GetRams();
		}
		public async Task<Ram> GetRam(int id) {
			return await _ramrep.GetRam(id);
		}
		public async Task<Ram> CreateRam(Ram ram) {
			return await _ramrep.InsertRam(ram);
		}
		public async Task<Ram> ChangeRam(int Id, int Stock) {
            var ram = await _ramrep.GetRam(Id);
            if (ram != null)
            {
                if (ram.Stock + Stock >= 0)
                {
                    ram.Stock += Stock;
                    await _ramrep.UpdateRam(ram);
                    return ram;
                }
                return null;
            }
            return null;
        }
		public async Task RemoveRam(int id) {
			await _ramrep.DeleteRam(id);
		}
	}
}
