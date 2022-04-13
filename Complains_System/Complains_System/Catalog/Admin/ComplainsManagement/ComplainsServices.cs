using Complains_System.EF;
using Complains_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;
using Complains_System.Constants;
using Microsoft.Data.SqlClient;

namespace Complains_System.Catalog.Admin.ComplainsManagement
{
    public class ComplainsServices : IComplainsService
    {
        private readonly ComplainsDbContext _context;
        private readonly IConfiguration _configuration;

        public ComplainsServices(ComplainsDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }
        public ReportForDepartment Statistics_Report(StatisticalRequest request)
        {
            List<Complain> complains = new List<Complain>();
            var sql = $"SELECT * FROM Complains where IdDepartment = {request.idDepartment} and date between '{request.startdate}' and '{request.enddate}'";
            var connectionString =  _configuration.GetConnectionString(SystemConstants.MainConnectionString);
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                complains = connection.Query<Complain>(sql).ToList();
                connection.Close();
            }
            if (complains == null) return null;

            var report = new ReportForDepartment()
            {
                Total = complains.Count(),
                Request = complains.Where(x => x.Status == "Chờ duyệt").ToList(),
                Done = complains.Where(x => x.Status == "Đã duyệt").ToList(),
                Cancel = complains.Where(x => x.Status == "Đã huỷ").ToList(),
                Spam = complains.Where(x => x.Status == "Spam").ToList()
            };

            return report;
        }
    }
}
