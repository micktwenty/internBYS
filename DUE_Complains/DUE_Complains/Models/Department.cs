using System;
using System.Collections.Generic;

#nullable disable

namespace DUE_Complains.Models
{
    public partial class Department
    {
        public Department()
        {
            Complains = new HashSet<Complain>();
            Employees = new HashSet<Employee>();
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Totalstudent { get; set; }
        public int? Totalemployee { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Complain> Complains { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
