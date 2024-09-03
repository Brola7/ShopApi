using System;
using System.Collections.Generic;

namespace FinalProject.Entities;

public partial class User
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public string PasswordHash { get; set; }
    public string PasswordSalt { get; set; }
    public virtual ICollection<UserRole> UserRoles { get; set; }
    public DateTime Created {  get; set; } = DateTime.Now;
}
