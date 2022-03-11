using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace DUE_Complains.Models
{
    public partial class Account
    {
        public Account()
        {
            Employees = new HashSet<Employee>();
        }
        [Required]
        public string Username { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
        public bool Actived { get; set; }

        public virtual Student Student { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
  
}
