using System.ComponentModel.DataAnnotations;

namespace FinalProject.Entities
{
    public class Role
    {
        public int Id { get; set; }
        [MaxLength(10)]
        public string Name { get; set; } = "User";
        public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
    }
}
