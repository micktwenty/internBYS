using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Complains_System.Models
{
    [Table("Employees")]
    public class Employee
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public Department Department { get; set; }
        public List<Complain> Idcomplains { get; set; }

    }
}
