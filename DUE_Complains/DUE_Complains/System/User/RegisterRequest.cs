﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DUE_Complains.System.User
{
    public class RegisterRequest_Stu
    {
        public string UserName { get; set; }
        public int IdDepartment { get; set; }
        public string ClassCode { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
