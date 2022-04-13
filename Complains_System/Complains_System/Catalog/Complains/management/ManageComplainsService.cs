

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

namespace Complains_System.Catalog.Complains.management
{
    public class ManageComplainsService : IComplainsManagement
    {
        private readonly ComplainsDbContext _context;
        private readonly IStorageService _storageService;


        public ManageComplainsService(ComplainsDbContext context, IStorageService storageService)
        {

            _context = context;
            _storageService = storageService;
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



        public async Task<string> EditCraft(EditDraftRequest request)
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
                    //Picture = x.c.Picture,
                    Date = x.c.Date,
                    Reply = x.c.Reply,
                    Status = x.c.Status,
                    IsPublic = x.c.IsPublic,
                    picture = x.image
                    
                }).ToListAsync();


            return data;
        }

        public async Task<PageResult<ComplainsViewModel>> GetAllbyKeyword(GetComplainsPagingRequest request)
        {

            var query = from c in _context.Complains
                        join d in _context.Departments on c.IdDepartment equals d.DepartmentId
                        where /*c.Content.Contains(request.keyword) &&*/ c.IsPublic.Equals(true)
                        select new {c, d };
            if (!string.IsNullOrEmpty(request.keyword))
            {
                query = query.Where(x => x.c.Content.Contains(request.keyword));
            }

            if(request.idDepartment != null)
            {
                query = query.Where(p => request.idDepartment.Contains(p.d.DepartmentId));
            }

            int rows = await query.CountAsync();

            var data = await query
                .Select(x => new ComplainsViewModel()
                {
                    IdComplains = x.c.IdComplains,
                    Title = x.c.Title,
                    Department = x.d.Name,
                    Content = x.c.Content,
                    //Picture = x.c.Picture,
                    Date = x.c.Date,
                    Reply = x.c.Reply,
                    Status = x.c.Status,
                    IsPublic = x.c.IsPublic
                }).ToListAsync();
            var pageResult = new PageResult<ComplainsViewModel>()
            {
                TotalRecord = rows,
                item = data

            };
            return pageResult;
        }

        public async Task<ComplainsViewModel> GetbyId(int IDComplain)
        {

            var complain = await _context.Complains.FindAsync(IDComplain);
            var department = await _context.Departments.FirstOrDefaultAsync(x => x.DepartmentId == complain.IdDepartment) ;
            var image = await _context.ImageComplains.FirstOrDefaultAsync(x => x.IdComplain == IDComplain);


            var complainview = new ComplainsViewModel()
            {
                IdComplains = complain.IdComplains,
                Department = department.Name,
                Content = complain.Content,
                Title = complain.Title,
                Date = complain.Date,
                Reply = complain.Reply,
                Status = complain.Status,
                picture = image != null ? image.Path_image : null
            };
            return complainview;
        }

        public async Task<PageResult<ComplainsViewModel>> GetOwnPaging(GetComplainsPagingRequest request)
        {
            var query = from c in _context.Complains
                        join d in _context.Departments on c.IdDepartment equals d.DepartmentId
                        where c.IdStudent.Equals(request.idStudent)
                        select new { c, d };
            int rows = await query.CountAsync();

            var data = await query
                .Select(x => new ComplainsViewModel()
                {
                    IdComplains = x.c.IdComplains,
                    Title = x.c.Title,
                    Department = x.d.Name,
                    Content = x.c.Content,
                    //Picture = x.c.Picture,
                    Date = x.c.Date,
                    Reply = x.c.Reply,
                    Status = x.c.Status,
                    IsPublic = x.c.IsPublic
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

        //public async Task<string> Post(EditDraftRequest request)
        //{
        //    var complain = await _context.Complains.FindAsync(request.IdComplain);

        //    complain.Title = request.Title;
        //    complain.Content = request.Content;
        //    complain.Date = DateTime.Now;
        //    complain.IdDepartment = request.IdDepartment;
        //    complain.Status = "Chờ duyệt";
        //    if (request.ThumbnailImage != null)
        //    {
        //        var thumbnailimage = await _context.ImageComplains.FirstOrDefaultAsync(i => i.IdComplain == request.IdComplain);
        //        if (thumbnailimage != null)
        //        {

        //            thumbnailimage.filesize = Convert.ToInt32(request.ThumbnailImage.Length);
        //            thumbnailimage.Path_image = await this.SaveFile(request.ThumbnailImage);
        //            _context.ImageComplains.Update(thumbnailimage);
        //        };
        //        complain.ImageComplain = new List<ImageComplain>()
        //        {
        //            new ImageComplain()
        //            {
        //                content_image = complain.Title,
        //                filesize = Convert.ToInt32(request.ThumbnailImage.Length),
        //                Path_image = await this.SaveFile(request.ThumbnailImage),
                       
        //            }
        //        };
        //    }
        //    return await _context.SaveChangesAsync();
        //}

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
