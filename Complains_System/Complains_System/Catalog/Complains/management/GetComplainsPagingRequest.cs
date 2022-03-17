
using Complains_System.Catalog.Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Complains_System.Catalog.Complains.management
{
    public class GetComplainsPagingRequest : PagingRequestBase
    {
        public string keyword { get; set; }
        public List<int> idDepartment { get; set; }
        public string idStudent { get; set; }
        public int?  DepartmentId { get; set; }
    }
}
