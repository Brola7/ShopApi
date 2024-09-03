using FinalProject.DTOs;
using FinalProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Repositories {
	public interface IVCRepository {
		Task<IEnumerable<VideoCard>> GetVCs();
		Task<VideoCard> GetVC(int id);
		Task<VideoCard> InsertVC(VideoCard vc);
		Task<VideoCard> UpdateVC(VideoCard vc);
		Task DeleteVC(int id);
	}
}
