using Complains_System.Catalog.Complains.Dtos;
using Complains_System.Catalog.Department;
using Complains_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace Complains_System.Catalog.Admin.ComplainsManagement
{
    public class ReportForDepartment
    {
        public int Total { get; set; }
        public int Total_dep { get; set; }

        public int Request { get; set; }
        public int Spam { get; set; }
        public int Done { get; set; }
        public int Cancel { get; set; }
        public string[,] thongke { get; set; }
        public List<ListDepartments> Departments { get; set; }
        public IPagedList<ComplainsViewModel> Complains_list { get; set; }


    }
}
