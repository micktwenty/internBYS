
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.IO;
using Complains_System.EF;
using Complains_System.Models;
using Complains_System.Catalog.Complains.Dtos;
using Complains_System.Catalog.Public;
using Complains_System.Catalog.Admin;
using Complains_System.Catalog.Admin.DepartmentManagement.Dtos;

namespace Complains_System.Catalog.Complains.management
{
    public class ManageComplainsService : IComplainsManagement
    {
        private readonly ComplainsDbContext _context;
        private readonly IStorageService _storageService;
        private readonly IMailService _mailservice;



        public ManageComplainsService(ComplainsDbContext context, IStorageService storageService, IMailService mailservice)
        {

            _context = context;
            _storageService = storageService;
            _mailservice = mailservice;
        }
        public async Task<string> CreateDraft(ComplainsCreateRequest request)
        {
            var validator = new ComplainsRequestValidator();
            var result = await validator.ValidateAsync(request);
            if (!result.IsValid)
            {
                var message = string.Join(", ", result.Errors);

                return message;
            }
            var complain = new Complain()
            {
                IdStudent = request.IdStudent,
                IdDepartment = request.IdDepartment,
                Title = request.Title,
                Content = request.Content,
                Status = "Bản nháp",
                IsPublic = false,


            };
            if (request.ThumbnailImage != null)
            {
                complain.ImageComplain = new List<ImageComplain>()
                {
                    new ImageComplain()
                    {
                        content_image = complain.Title,
                        filesize = Convert.ToInt32(request.ThumbnailImage.Length),
                        Path_image = await this.SaveFile(request.ThumbnailImage),
    
                    }
                };
            }
            _context.Complains.Add(complain);
             await _context.SaveChangesAsync();
            return complain.IdComplains.ToString();
        }


        public async Task<int> Delete(int idComplain)
        {
            var complain = await _context.Complains.FindAsync(idComplain);
            var images =  _context.ImageComplains.Where( i => i.IdComplain == complain.IdComplains);
            foreach (var item in images)
            {
                await _storageService.DeleteFileAsync(item.Path_image);
            }
            _context.Complains.Remove(complain);
            return await _context.SaveChangesAsync();

        }

        public async Task<int> DenyPost(string reply, int idcomplains, int employee)
        {
            var data = await _context.Complains.FirstOrDefaultAsync(x => x.IdComplains == idcomplains);
            
            if (data != null)
            {
                data.Status = "Từ chối giải quyết";
                data.IsPublic = false;
                data.employee_reply = employee;
                data.Reply = reply;
            }
            var user = await _context.AppUsers.FirstOrDefaultAsync(x => x.UserName == data.IdStudent);
            var mail = new MailRequest()
            {
                Body = $"Chào {user.Name},sau khi xem xét bài đăng \"{data.Title}\" của bạn, chúng tôi hiểu nhưng chúng tôi chưa thể đưa ra hướng giải quyết cho bạn." +
                $" Về chi tiết lí do từ chối của phòng/ban mời bạn vui lòng truy cập trang web, đăng nhập và vào mục \"Quản lý bài đăng cá nhân\" để xem" +
              $". Nếu có bất kì thắc mắc nào bạn có thể đến \"Phòng tiếp nhận phản ánh\" tại tầng " +
              $"20 toà nhà mới trường Đại học Kinh Tế Đà Nẵng địa chỉ: 71 Ngũ Hành Sơn - thành phố Đà Nẵng. Trân trọng cảm ơn! ",
                Subject = $"Phản hồi về bài đăng \"{data.Title}\"",
                ToEmail = user.Email
            };
            
            await _mailservice.SendEmailAsync(mail);
            return await _context.SaveChangesAsync();
        }

        public async Task<string> EditDraft(EditDraftRequest request)
        {
            var complain = await _context.Complains.FindAsync(request.IdComplain);

            complain.Title = request.Title;
            complain.Content = request.Content;
            complain.Date = DateTime.Now;
            complain.IdDepartment = request.IdDepartment;
            if (request.ThumbnailImage != null)
            {
                var images = _context.ImageComplains.Where(i => i.IdComplain == complain.IdComplains);
                foreach (var item in images)
                {
                    await _storageService.DeleteFileAsync(item.Path_image);
                }
                var thumbnailimage = await _context.ImageComplains.FirstOrDefaultAsync(i =>  i.IdComplain == request.IdComplain);
                if (thumbnailimage != null)
                {

                    thumbnailimage.filesize = Convert.ToInt32(request.ThumbnailImage.Length);
                    thumbnailimage.Path_image = await this.SaveFile(request.ThumbnailImage);
                    _context.ImageComplains.Update(thumbnailimage);
                };
                complain.ImageComplain = new List<ImageComplain>()
                {
                    new ImageComplain()
                    {
                        content_image = complain.Title,
                        filesize = Convert.ToInt32(request.ThumbnailImage.Length),
                        Path_image = await this.SaveFile(request.ThumbnailImage),
                    }
                };
            }
            _context.Complains.Update(complain);
            var result = await _context.SaveChangesAsync();
            if (result > 0)
            {
                return request.IdComplain.ToString();
            }
            return result.ToString();

        }

        public async Task<List<ComplainsViewModel>> GetAll()
        {
            var query = from c in _context.Complains
                        join d in _context.Departments on c.IdDepartment equals d.DepartmentId
                        join e in _context.ImageComplains on c.IdComplains equals e.IdComplain into complain
                        from cpl in complain.DefaultIfEmpty()
                        where c.IsPublic.Equals(true)
                        select new { c, d, image = (cpl.Path_image == null) ? "depositphotos_223101402-stock-illustration-complaint-icon-trendy-design-style.jpg" :  cpl.Path_image};
           

            var data = await query.Select(x => new ComplainsViewModel()
                {
                    IdComplains = x.c.IdComplains,
                    Title = x.c.Title,
                    Department = x.d.Name,
                    Content = x.c.Content,
                    Date = x.c.Date,
                    Reply = x.c.Reply,
                    Status = x.c.Status,
                    IsPublic = x.c.IsPublic,
                    picture = x.image
                    
                }).ToListAsync();


            return data;
        }

        public async Task<List<ComplainsViewModel>> GetAllbyKeyword(GetComplainsPagingRequest request)
        {

            var query = from c in _context.Complains
                        join d in _context.Departments on c.IdDepartment equals d.DepartmentId
                        where c.IsPublic.Equals(true)
                        select new {c, d };
            if (!string.IsNullOrEmpty(request.keyword))
            {
                query = query.Where(x => x.c.Content.Contains(request.keyword) || x.c.Title.Contains(request.keyword));
            }



            int rows = await query.CountAsync();

            var data = await query
                .Select(x => new ComplainsViewModel()
                {
                    IdComplains = x.c.IdComplains,
                    Title = x.c.Title,
                    Department = x.d.Name,
                    Content = x.c.Content,
                    Date = x.c.Date,
                    Reply = x.c.Reply,
                    Status = x.c.Status,
                    IsPublic = x.c.IsPublic
                }).ToListAsync();

            return data;
        }

        public async Task<ComplainsViewModel> GetbyId(int IDComplain)
        {
            if (IDComplain == 0)
            {
                return new ComplainsViewModel();
            }
            var complain = await _context.Complains.FindAsync(IDComplain);
            var department = await _context.Departments.FirstOrDefaultAsync(x => x.DepartmentId == complain.IdDepartment) ;
            var image = await _context.ImageComplains.FirstOrDefaultAsync(x => x.IdComplain == IDComplain);
            var employee = await _context.Employees.FirstOrDefaultAsync(x => x.Id == complain.employee_reply);


            var complainview = new ComplainsViewModel()
            {
                IdComplains = complain.IdComplains,
                Department = department.Name,
                Content = complain.Content,
                Title = complain.Title,
                Date = complain.Date,
                Reply = complain.Reply,
                Status = complain.Status,
                employee_reply = (employee == null)? "Đang chờ duyệt!" : employee.Name,
                picture = image != null ? image.Path_image : null,
                IdStudent = complain.IdStudent,
                IsPublic = complain.IsPublic
            };
            return complainview;
        }

        public async Task<PageResult<ComplainsViewModel>> GetOwnPaging(GetComplainsPagingRequest request)
        {
            var query = from c in _context.Complains
                        join d in _context.Departments on c.IdDepartment equals d.DepartmentId
                        join e in _context.ImageComplains on c.IdComplains equals e.IdComplain into complain
                        from cpl in complain.DefaultIfEmpty()
                        where c.IdStudent.Equals(request.idStudent)
                        select new { c, d, image = (cpl.Path_image == null) ? "depositphotos_223101402-stock-illustration-complaint-icon-trendy-design-style.jpg" : cpl.Path_image };
            if (request.status != null)
            {
                query = from c in _context.Complains
                        join d in _context.Departments on c.IdDepartment equals d.DepartmentId
                        join e in _context.ImageComplains on c.IdComplains equals e.IdComplain into complain
                        from cpl in complain.DefaultIfEmpty()
                        where c.IdStudent.Equals(request.idStudent) && c.Status.Equals(request.status)
                        select new { c, d, image = (cpl.Path_image == null) ? "depositphotos_223101402-stock-illustration-complaint-icon-trendy-design-style.jpg" : cpl.Path_image };
            }
            int rows = await query.CountAsync();

            var data = await query
                .Select(x => new ComplainsViewModel()
                {
                    IdComplains = x.c.IdComplains,
                    Title = x.c.Title,
                    Department = x.d.Name,
                    Content = x.c.Content,
                    Date = x.c.Date,
                    Reply = x.c.Reply,
                    Status = x.c.Status,
                    IsPublic = x.c.IsPublic,
                    picture = x.image
                }).ToListAsync();
            var pageResult = new PageResult<ComplainsViewModel>()
            {
                TotalRecord = rows,
                item = data

            };
            return pageResult;
        }

        public async Task<List<ComplainsViewModel>> GetRequestPost(int ID)
        {
            var query = from c in _context.Complains
                        join e in _context.ImageComplains on c.IdComplains equals e.IdComplain into complain
                        from cpl in complain.DefaultIfEmpty()
                        where c.IdDepartment.Equals(ID) && c.Status.Equals("Chờ duyệt")
                        select new { c, image = (cpl.Path_image == null) ? "depositphotos_223101402-stock-illustration-complaint-icon-trendy-design-style.jpg" : cpl.Path_image };


            var data = await query.Select(x => new ComplainsViewModel()
            {
                IdComplains = x.c.IdComplains,
                Title = x.c.Title,
                Content = x.c.Content,
                Date = x.c.Date,
                Reply = x.c.Reply,
                Status = x.c.Status,
                IsPublic = x.c.IsPublic,
                picture = x.image

            }).ToListAsync();


            return data;
        }



        public async Task<string> PostRequest(ComplainsCreateRequest request)
        {
            var complain = new Complain()
            {
                IdStudent = request.IdStudent,
                IdDepartment = request.IdDepartment,
                Title = request.Title,
                Content = request.Content,
                Status = "Chờ duyệt",
                IsPublic = false,
            };
            if (request.ThumbnailImage != null)
            {
                complain.ImageComplain = new List<ImageComplain>()
                {
                    new ImageComplain()
                    {
                        content_image = complain.Title,
                        filesize = Convert.ToInt32(request.ThumbnailImage.Length),
                        Path_image = await this.SaveFile(request.ThumbnailImage),

                    }
                };
            }
            var user = await _context.AppUsers.FirstOrDefaultAsync(x => x.UserName == request.IdStudent);
            var mail = new MailRequest()
            {
                Body = $"Chào {user.Name}, hệ thống đã tiếp nhận bài đăng \"{complain.Title}\" của bạn, chúng tôi sẽ gửi thông báo qua email cho bạn khi có phản hồi từ phòng/ban." +
                $" Bạn có thể truy cập trang web, đăng nhập và vào mục \"Quản lý bài đăng cá nhân\" để theo dõi trạng thái bài đăng mới nhất" +
              $".Nếu có bất kì thắc mắc nào bạn có thể đến \"Phòng tiếp nhận phản ánh\" tại tầng " +
              $"20 toà nhà mới trường Đại học Kinh Tế Đà Nẵng địa chỉ: 71 Ngũ Hành Sơn - thành phố Đà Nẵng. Trân trọng cảm ơn",
                Subject = $"Thông báo về bài đăng \"{complain.Title}\"",
                ToEmail = user.Email
            };
            await _mailservice.SendEmailAsync(mail);
            _context.Complains.Add(complain);
            await _context.SaveChangesAsync();
            return complain.IdComplains.ToString();
        }

        public async Task<int> ReplyComplain(string reply, int idcomplains, int idemployee)
        {

            var data = await _context.Complains.FirstOrDefaultAsync(x => x.IdComplains == idcomplains);
            data.Reply = reply;
            if (reply != null)
            {
                data.Status = "Đã duyệt!";
                data.IsPublic = true;
                data.employee_reply = idemployee;
            }
            var user = await _context.AppUsers.FirstOrDefaultAsync(x => x.UserName == data.IdStudent);
            var mail = new MailRequest()
            {
                Body = $"Chào {user.Name},sau khi xem xét bài đăng \"{data.Title}\" của bạn, chúng tôi hiểu và đã đưa ra hướng giải quyết cho bạn, đồng thời cũng đăng bài đăng của bạn lên " +
                $"trang DUE Complains. Về chi tiết hướng giải quyết và câu trả lời của phòng/ban mời bạn vui lòng truy cập trang web, đăng nhập và vào mục \"Quản lý bài đăng cá nhân\" để xem" +
              $". Nếu có bất kì thắc mắc nào bạn có thể đến \"Phòng tiếp nhận phản ánh\" tại tầng " +
              $"20 toà nhà mới trường Đại học Kinh Tế Đà Nẵng địa chỉ: 71 Ngũ Hành Sơn - thành phố Đà Nẵng. Trân trọng cảm ơn!",
                Subject = $"Phản hồi về bài đăng \"{data.Title}\"",
                ToEmail = user.Email
            };
            await _mailservice.SendEmailAsync(mail);
            return await _context.SaveChangesAsync();

        }

        public async Task<int> SpamPost(string reply, int idcomplains, int employee)
        {
            var data = await _context.Complains.FirstOrDefaultAsync(x => x.IdComplains == idcomplains);
            var user = await _context.AppUsers.FirstOrDefaultAsync(x => x.UserName == data.IdStudent);
            if (data != null)
            {
                data.Status = "Spam";
                data.IsPublic = false;
                data.employee_reply = employee;
                data.Reply = reply;
            }
            var mail = new MailRequest()
            {
                Body = $"Chào {user.Name}, Sau khi xem xét bài đăng \"{data.Title}\" của bạn, chúng tôi nhận thấy nội dung không đúng và chưa thể đưa ra hướng giải quyết " +
                $"cho bạn, vì vậy chúng tôi đã đánh dấu bài của bạn là \"SPAM\". \nNếu có bất kì thắc mắc nào bạn có thể đến \"Phòng tiếp nhận phản ánh\" tại tầng " +
                $"20 toà nhà mới trường Đại học Kinh Tế Đà Nẵng địa chỉ: 71 Ngũ Hành Sơn - thành phố Đà Nẵng. Trân trọng cảm ơn!",
                Subject = $"Phản hồi về bài đăng \"{data.Title}\"",
                ToEmail = user.Email
            };
            await _mailservice.SendEmailAsync(mail);
            return await _context.SaveChangesAsync();

        }

        private async Task<string> SaveFile(IFormFile file)
        {
            var origanalName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(origanalName)}";
            await _storageService.SaveFileAsync(file.OpenReadStream(), fileName);
            return fileName;
        }
    }
}
