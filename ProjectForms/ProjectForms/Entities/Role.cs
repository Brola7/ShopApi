﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForms.Entities
{
    public class Role
    {
        public int Id { get; set; }
        [MaxLength(10)]
        public string Name { get; set; } = "User";
        public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
    }
}
