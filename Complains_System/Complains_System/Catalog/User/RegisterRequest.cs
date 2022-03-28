﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Complains_System.Catalog.User
{
    public class RegisterRequest
    {
         [Display(Name="Tạo cho nhân viên nhà trường?")]
        public bool Isemployee { get; set; }

        public string Name { get; set; }
        public string UserName { get; set; }

        public string Email { get; set; }
        public int IdDepartment { get; set; }
        public string sClass { get; set; }

        public string IdStudent { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
