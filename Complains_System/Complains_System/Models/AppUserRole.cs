using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Complains_System.Models
{
    public class AppUserRole : IdentityUserRole<string>
    {
        public AppUser AppUser { get; set; }
    }
}
