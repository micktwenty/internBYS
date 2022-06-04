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
        public AppRole AppRole { get; set; }

        public string username { get; set; }
        public string Discriminator { get; set; }
    }
}
