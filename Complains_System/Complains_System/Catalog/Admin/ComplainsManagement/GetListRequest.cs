using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Complains_System.Catalog.Admin.ComplainsManagement
{
    public class GetListRequest
    {
        public DateTime startdate { get; set; }
        public DateTime enddate { get; set; }
        public int IdDep { get; set; }
        public string Status { get; set; }

    }
}
