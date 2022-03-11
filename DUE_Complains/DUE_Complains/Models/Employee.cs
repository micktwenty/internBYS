using System;
using System.Collections.Generic;

#nullable disable

namespace DUE_Complains.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public int? IdDepartment { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Picture { get; set; }
        public string Username { get; set; }

        public virtual Department IdDepartmentNavigation { get; set; }
        public virtual Account UsernameNavigation { get; set; }
    }
}
