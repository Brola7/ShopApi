using FinalProject.DTOs;
using FinalProject.Entities;
using FinalProject.Repositories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Services {
	public class MBService : IMBService {
		private readonly IMBRepository _mbrep;
		public MBService(IMBRepository mbrep) {
			_mbrep = mbrep;
		}
		public async Task<IEnumerable<MotherBoard>> GetAllMBs() {
			return await _mbrep.GetMBs();
		}
		public async Task<MotherBoard> GetMB(int id) {
			return await _mbrep.GetMB(id);
		}
		public async Task<MotherBoard> CreateMB(MotherBoard mb) {
			return await _mbrep.InsertMB(mb);
		}
		public async Task<MotherBoard> ChangeMB(int Id, int Stock) {
            var mb = await _mbrep.GetMB(Id);
            if (mb != null)
            {
                if (mb.Stock + Stock >= 0)
                {
                    mb.Stock += Stock;
                    await _mbrep.UpdateMB(mb);
                    return mb;
                }
                return null;
            }
            return null;
        }
		public async Task RemoveMB(int id) {
			await _mbrep.DeleteMB(id);
		}
	}
}
