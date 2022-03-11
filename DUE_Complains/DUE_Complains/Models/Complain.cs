using System;
using System.Collections.Generic;

#nullable disable

namespace DUE_Complains.Models
{
    public partial class Complain
    {
        public string IdStudent { get; set; }
        public int IdComplains { get; set; }
        public int IdDepartment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Reply { get; set; }
        public DateTime? Date { get; set; }
        public bool IsPublic { get; set; }
        public string Status { get; set; }
        
        public List<Department> DepInfo { get; set; }
        public virtual Department IdDepartmentNavigation { get; set; }
        public virtual Student IdStudentNavigation { get; set; }
        public virtual ICollection<ImageComplain> ImageComplain { get; set; }

    }
}
