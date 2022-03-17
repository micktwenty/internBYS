using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Complains_System.Models
{
    [Table("AppRoles")]
    public class AppRole : IdentityRole
    {
        public string Description { get; set; }
    }
}
