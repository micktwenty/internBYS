using Complains_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Complains_System.Catalog.Admin.UserManagement.Dtos
{
    public class UserViewModel
    {
        public AppUser user { get; set; }
        public string username { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public List<Role> Role { get; set; }
        
    }
}
