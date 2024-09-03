using FinalProject.DTOs;
using FinalProject.Entities;
using FinalProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Services {
	public class VCService : IVCService {
		private readonly IVCRepository _vcrep;
		public VCService(IVCRepository vcrep) {
			_vcrep = vcrep;
		}
		public async Task<IEnumerable<VideoCard>> GetAllVCs() {
			return await _vcrep.GetVCs();
		}
		public async Task<VideoCard> GetVC(int id) {
			return await _vcrep.GetVC(id);
		}
		public async Task<VideoCard> CreateVC(VideoCard vc) {
			return await _vcrep.InsertVC(vc);
		}
		public async Task<VideoCard> ChangeVC(int Id, int Stock) {
            var vc = await _vcrep.GetVC(Id);
            if (vc != null)
            {
                if (vc.Stock + Stock >= 0)
                {
                    vc.Stock += Stock;
                    await _vcrep.UpdateVC(vc);
                    return vc;
                }
                return null;
            }
            return null;
        }
		public async Task RemoveVC(int id) {
			await _vcrep.DeleteVC(id);
		}
	}
}
