using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Complains_System.Models
{
    [Table("AppUsers")]
    public class AppUser : IdentityUser
    {
        [TempData]
        public string Name { get; set; }
        public int IdDepartment  { get; set; }
        public string IdStudent { get; set; }
        public int idteacher { get; set; }
        public bool IsActive { get; set; }
        public string Roles { get; set; }

    }
}
