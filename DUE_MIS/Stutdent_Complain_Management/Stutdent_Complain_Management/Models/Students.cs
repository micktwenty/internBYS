using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stutdent_Complain_Management.Models
{
    [Table("Student")]
    public class Students
    {
        public string studentcode { get; set; }
        public string name { get; set; }
        public string _class { get; set; }
        public int Department { get; set; }
        public string email { get; set; }
        public string phone { get; set; }

    }
    public class RegisterViewModel
    {
        [Required]
        [MaxLength(225)]
        [Display(Name = "Mã số sinh viên")]
        public string studentcode { get; set; }

        [Required]
        [Display(Name = "Khoa")]
        public int Department { get; set; }

        [Required]
        [Display(Name = "Lớp sinh hoạt")]
        public int sClass { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

}