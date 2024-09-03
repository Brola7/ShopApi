using FinalProject.DTOs;
using FinalProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Services {
	public interface IVCService {
		Task<IEnumerable<VideoCard>> GetAllVCs();
		Task<VideoCard> GetVC(int id);
		Task<VideoCard> CreateVC(VideoCard vc);
		Task<VideoCard> ChangeVC(int Id, int Stock);
		Task RemoveVC(int id);
	}
}
