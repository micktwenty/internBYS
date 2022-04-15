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
using X.PagedList;
using Complains_System.Catalog.Complains.Dtos;

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
        public ReportForDepartment Statistics_Report(int? page)
        {
            List<Complain> complains = new List<Complain>();
            var sql = $"SELECT * FROM Complains";
            var connectionString =  _configuration.GetConnectionString(SystemConstants.MainConnectionString);
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                complains = connection.Query<Complain>(sql).ToList();
                connection.Close();
            }
            if (complains == null) return null;
            var pageNumber = page ?? 1;
            pageNumber = pageNumber == 0 ? 1 : pageNumber;
            var pageSize = 6;
            var data = from c in _context.Complains
                       join d in _context.Departments on c.IdDepartment equals d.DepartmentId
                       
                       select new { c, d };
            var new_data = data.Select(x => new ComplainsViewModel()
            {
                Content = x.c.Content,
                Status = x.c.Status,
                Title = x.c.Title,
                Department = x.d.Name,
                Reply = x.c.Reply,
                Date = x.c.Date,
                IdComplains = x.c.IdComplains
            }).ToList();
            var report = new ReportForDepartment()
            {
                Total = complains.Count(),
                Total_dep = _context.Departments.Count(),
                Request = complains.Where(x => x.Status == "Chờ duyệt").Count(),
                Done = complains.Where(x => x.Status == "Đã duyệt!").Count(),
                Cancel = complains.Where(x => x.Status == "Đã huỷ").Count(),
                Spam = complains.Where(x => x.Status == "Spam").Count(),
                thongke = thongke(null),
                Complains_list = new_data.OrderByDescending(x => x.Date).ToPagedList(pageNumber, pageSize)
            };

            return report;
        }

        public ReportForDepartment Statistics_Report_Department(StatisticalRequest request, int? page)
        {
            List<Complain> complains = new List<Complain>();
           
            var sql = $"SELECT * FROM Complains where date between '{request.startdate}' and '{request.enddate}'";
           
            var connectionString = _configuration.GetConnectionString(SystemConstants.MainConnectionString);
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                complains = connection.Query<Complain>(sql).ToList();
              
                connection.Close();
            }
            if (complains == null) return null;
            var pageNumber = page ?? 1;
            pageNumber = pageNumber == 0 ? 1 : pageNumber;
            var pageSize = 6;
            var data = from c in _context.Complains
                       join d in _context.Departments on c.IdDepartment equals d.DepartmentId
                       where c.Date >= request.startdate && c.Date <= request.enddate
                       select new { c, d };
            var new_data = data.Select(x => new ComplainsViewModel()
            {
                Content = x.c.Content,
                Status = x.c.Status,
                Title = x.c.Title,
                Department = x.d.Name,
                Reply = x.c.Reply,
                Date = x.c.Date,
                IdComplains = x.c.IdComplains
            }).ToList();
            var report = new ReportForDepartment()
            {
                Total = complains.Count(),
                Total_dep = _context.Departments.Count(),
                Request = complains.Where(x => x.Status == "Chờ duyệt").Count(),
                Done = complains.Where(x => x.Status == "Đã duyệt").Count(),
                Cancel = complains.Where(x => x.Status == "Đã huỷ").Count(),
                Spam = complains.Where(x => x.Status == "Spam").Count(),
                thongke = thongke(request),
                Complains_list = new_data.OrderByDescending(x => x.Date).ToPagedList(pageNumber, pageSize)
            };

            return report;
        }
        private string[,] thongke(StatisticalRequest? request)
        {
            List<Complains_System.Models.Department> dep = new List<Complains_System.Models.Department>();
            var sql2 = $"SELECT * FROM Departments";

            var connectionString = _configuration.GetConnectionString(SystemConstants.MainConnectionString);
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                dep = connection.Query<Models.Department>(sql2).ToList();
                connection.Close();
            }
            string[,] thongke = new string[dep.Count,5];
            int j = 0;
            foreach (var item in dep)
            {

                var sql = $"SELECT * FROM Complains where IdDepartment = {j + 1}";
                if (request != null)
                {
                    sql = $"SELECT * FROM Complains where IdDepartment = {j + 1} and date between '{request.startdate}' and '{request.enddate}'";
                }
                List<Complain> complains = new List<Complain>();

                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    complains = connection.Query<Complain>(sql).ToList();

                    connection.Close();
                }
               
                    for (int i = 0; i < 5; i++)
                    {
                        if (i == 4)
                        {
                            thongke[j, i] = $"{complains.Count()}";
                            break;
                        }

                        string status = "Đã duyệt!";
                        switch (i)
                        {
                            case 0:
                                status = "Đã duyệt!";
                                break;
                            case 1:
                                status = "Spam";
                                break;
                            case 2:
                                status = "Đã huỷ";
                                break;
                            case 3:
                                status = "Bản nháp";
                                break;
                        }
                        if (complains.Count() == 0)
                        {
                            thongke[j, i] = "0(0%)";
                        }
                        else
                        {
                            thongke[j, i] = $"{complains.Where(x => x.Status == status).Count()} ({(complains.Where(x => x.Status == status).Count()) * 100 / complains.Count()}%)";
                        }
                    }
                j++;
            }
            return thongke;

        }
    }
}
