using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DUE_Complains.BackendAPI.Commons
{
    public class PagingRequestBase
    {
        public int pageIndex { get; set; }
        public int PageSize { get; set; }
    }
}
