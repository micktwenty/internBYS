using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stutdent_Complain_Management.Models
{
    [Table("Students")]
    public class Students
    {
        [Required]
        [MaxLength(225)]
        [Display(Name = "Mã số sinh viên")]
        public string studentcode { get; set; }
        [Required]
        [Display(Name = "Họ và tên")]
        public string name { get; set; }
        [Required]
        [Display(Name = "Lớp sinh hoạt")]
        public string sclass { get; set; }
        public int Department { get; set; }
        [Required]
        [Display(Name = "Email DUE")]
        public string email { get; set; }
        [Required]
        [Display(Name = "Số điện thoại")]
        public string phone { get; set; }

    }
    public class RegisterViewModel_Stu : Students
    {

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [NotMapped]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        
    }

}