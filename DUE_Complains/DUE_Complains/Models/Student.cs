using System;
using System.Collections.Generic;

#nullable disable

namespace DUE_Complains.Models
{
    public partial class Student
    {
        public Student()
        {
            Complains = new HashSet<Complain>();
        }

        public string Studentcode { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
        public string Sclass { get; set; }
        public int? Department { get; set; }

        public virtual Department DepartmentNavigation { get; set; }
        public virtual Account StudentcodeNavigation { get; set; }
        public virtual ICollection<Complain> Complains { get; set; }
    }
}
