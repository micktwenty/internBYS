using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Complains_System.Catalog.Complains.Dtos
{
    public class ComplainsViewModel
    {
        public int IdComplains { get; set; }
        public string Department { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Reply { get; set; }
        public DateTime? Date { get; set; }
        public bool IsPublic { get; set; }
        public string Status { get; set; }
        public string employee_reply { get; set; }
        public string picture { get; set; }
        public string IdStudent { get; set; }

    }
}
