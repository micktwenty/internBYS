using Complains_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Complains_System.Catalog.Admin.ComplainsManagement
{
     public interface IComplainsService
    {
        public ReportForDepartment Statistics_Report(StatisticalRequest request);
    }
}
