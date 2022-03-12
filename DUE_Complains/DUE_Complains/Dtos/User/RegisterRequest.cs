using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DUE_Complains.System.User
{
    public class RegisterRequest
    {
        public string? Name { get; set; }
        public string UserName { get; set; }
        public string? Email { get; set; }
        public int IdDepartment { get; set; }
        public string? IdStudent { get; set; }
        public int? IdTeacher { get; set; }
        public string ClassCode { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
