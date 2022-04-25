using Complains_System.Catalog.Admin;
using Complains_System.Catalog.Admin.DepartmentManagement.Dtos;
using Complains_System.Catalog.Department;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Complains_System.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DepartmentService : Controller
    {

        private readonly IDepartmentService _departmentService;

        public DepartmentService( IDepartmentService departmentService)
        {

            this._departmentService = departmentService;
        }
        [Route("SendMail/{id}")]
        public async Task<IActionResult> SendMail(int id)
        {
            try
            {
                await _departmentService.SendWarning(id);
                return RedirectToAction("Index", "admin");
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        [HttpGet("new-department")]
        public async Task<IActionResult> CreateDepartment()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateDepartment([FromForm] CreateRequest request)
        {
           var result =  await _departmentService.CreateDepartment(request);
            if (result > 0)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("manage-department")]
        public async Task<IActionResult> manage_department()
        {
            var data = await _departmentService.GetListDepartments();
            return View(data);
        }

    }
}
