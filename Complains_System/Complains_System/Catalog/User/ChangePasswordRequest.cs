using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Complains_System.Catalog.User
{
    public class ChangePasswordRequest
    {
        public string username { get; set; }
        public string OldPass { get; set; }
        public string NewPass { get; set; }
        public string ConfirmNewPass { get; set; }


    }
}
