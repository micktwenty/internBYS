using DUE_Complains.BackendAPI.Commons;
using DUE_Complains.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DUE_Complains.BackendAPI.Complains
{
    public class GetComplainsPagingRequest : PagingRequestBase
    {
        public string? keyword { get; set; }
        public List<int>? idDepartment { get; set; }
        public string idStudent { get; set; }
        public int?  DepartmentId { get; set; }
    }
}
