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

        public async Task<List<ComplainsViewModel>> GetListComplains(GetListRequest request)
        {

            if (request.Status == "all")
            {
                var query = from c in _context.Complains
                            join d in _context.Departments on c.IdDepartment equals d.DepartmentId
                            join e in _context.ImageComplains on c.IdComplains equals e.IdComplain into complain
                            from cpl in complain.DefaultIfEmpty()
                            where c.IdDepartment.Equals(request.IdDep) && c.Status != "Bản nháp"
                            select new { c, d, image = (cpl.Path_image == null) ? "depositphotos_223101402-stock-illustration-complaint-icon-trendy-design-style.jpg" : cpl.Path_image };
                var data = await query.Select(x => new ComplainsViewModel()
                {
                    IdComplains = x.c.IdComplains,
                    Title = x.c.Title,
                    Department = x.d.Name,
                    Content = x.c.Content,
                    //Picture = x.c.Picture,
                    Date = x.c.Date,
                    Reply = x.c.Reply,
                    Status = x.c.Status,
                    IsPublic = x.c.IsPublic,
                    picture = x.image

                }).Where(x => x.Date >= request.startdate && x.Date <= request.enddate).ToListAsync();
                data = data.OrderByDescending(x => x.Date).ToList();


                return data;
            }
            else
            {
                 var query = from c in _context.Complains
                            join d in _context.Departments on c.IdDepartment equals d.DepartmentId
                            join e in _context.ImageComplains on c.IdComplains equals e.IdComplain into complain
                            from cpl in complain.DefaultIfEmpty()
                            where c.IdDepartment.Equals(request.IdDep) && c.Status.Equals(request.Status)
                            select new { c, d, image = (cpl.Path_image == null) ? "depositphotos_223101402-stock-illustration-complaint-icon-trendy-design-style.jpg" : cpl.Path_image };
                var data = await query.Select(x => new ComplainsViewModel()
                {
                    IdComplains = x.c.IdComplains,
                    Title = x.c.Title,
                    Department = x.d.Name,
                    Content = x.c.Content,
                    //Picture = x.c.Picture,
                    Date = x.c.Date,
                    Reply = x.c.Reply,
                    Status = x.c.Status,
                    IsPublic = x.c.IsPublic,
                    picture = x.image

                }).Where(x => x.Date >= request.startdate && x.Date <= request.enddate).ToListAsync();

                data = data.OrderByDescending(x => x.Date).ToList();

                return data;
            }
           


           
        }

        public ReportForDepartment Statistics_Report(int? page)
        {
            List<Complain> complains = new List<Complain>();
            var sql = $"SELECT * FROM Complains where status <> N'Bản nháp'";
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
                       where c.Status != "Bản nháp"
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
            string[] listStt = {"Đã duyệt!", "Spam", "Từ chối giải quyết", "Chờ duyệt", "all"  };
            var report = new ReportForDepartment()
            {
                Total = complains.Count(),
                Total_dep = _context.Departments.Count(),
                Request = complains.Where(x => x.Status == "Chờ duyệt").Count(),
                Done = complains.Where(x => x.Status == "Đã duyệt!").Count(),
                Cancel = complains.Where(x => x.Status == "Từ chối giải quyết").Count(),
                Spam = complains.Where(x => x.Status == "Spam").Count(),
                thongke = thongke(null),
                Status = listStt,
                Complains_list = new_data.OrderByDescending(x => x.Date).ToPagedList(pageNumber, pageSize)
            };

            return report;
        }

        public ReportForDepartment Statistics_Report_Department(StatisticalRequest request, int? page)
        {
            List<Complain> complains = new List<Complain>();
            TimeSpan aInterval = new System.TimeSpan(1, 0, 0, 0);

            var sql = $"SELECT * FROM Complains where [status] <> N'Bản nháp' and date between '{request.startdate.Subtract(aInterval)}' and '{request.enddate.AddDays(1)}'";
           
            var connectionString = _configuration.GetConnectionString(SystemConstants.MainConnectionString);
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                complains = connection.Query<Complain>(sql).ToList();
              
                connection.Close();
            }

            //var pageNumber = page ?? 1;
            //pageNumber = pageNumber == 0 ? 1 : pageNumber;
            //var pageSize = 6;

            //var data = from c in _context.Complains
            //           join d in _context.Departments on c.IdDepartment equals d.DepartmentId
            //           where c.Date.ToString().CompareTo(request.startdate) >= 0 && c.Date.ToString().CompareTo(request.enddate) <= 0
            //           select new { c, d };
            //var new_data =data.Select(x => new ComplainsViewModel()
            //{
            //    Content = x.c.Content,
            //    Status = x.c.Status,
            //    Title = x.c.Title,
            //    Department = x.d.Name,
            //    Reply = x.c.Reply,
            //    Date = x.c.Date,
            //    IdComplains = x.c.IdComplains
            //}).ToList();
            string[] listStt = { "Đã duyệt!", "Spam", "Từ chối giải quyết", "Chờ duyệt" ,"all"};

            var report = new ReportForDepartment()
            {
                Total = complains.Count(),
                Total_dep = _context.Departments.Count(),
                Request = complains.Where(x => x.Status == "Chờ duyệt").Count(),
                Done = complains.Where(x => x.Status == "Đã duyệt!").Count(),
                Cancel = complains.Where(x => x.Status == "Từ chối giải quyết").Count(),
                Spam = complains.Where(x => x.Status == "Spam").Count(),
                Status = listStt,

                thongke = thongke(request),
                //Complains_list = new_data.OrderByDescending(x => x.Date).ToPagedList(pageNumber, pageSize)
            };

            return report;
        }
        private string[,] thongke(StatisticalRequest? request)
        {
            List<Complains_System.Models.Department> dep = new List<Complains_System.Models.Department>();
            var sql2 = $"SELECT * FROM Departments";
            TimeSpan aInterval = new System.TimeSpan(1, 0, 0, 0);

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

                var sql = $"SELECT * FROM Complains where [status] <> N'Bản nháp' and IdDepartment = {j + 1}";
                if (request != null)
                {
                    sql = $"SELECT * FROM Complains where [status] <> N'Bản nháp' and IdDepartment = {j + 1} and date between '{request.startdate.Subtract(aInterval)}' and '{request.enddate.Add(aInterval)}'";
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
                                status = "Từ chối giải quyết";
                                break;
                            case 3:
                                status = "Chờ duyệt";
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
