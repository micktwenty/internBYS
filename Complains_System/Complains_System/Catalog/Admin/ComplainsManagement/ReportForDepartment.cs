using Complains_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Complains_System.Catalog.Admin.ComplainsManagement
{
    public class ReportForDepartment
    {
        public int Total { get; set; }
        public List<Complain> Request { get; set; }
        public List<Complain> Spam { get; set; }
        public List<Complain> Done { get; set; }
        public List<Complain> Cancel { get; set; }


    }
}
