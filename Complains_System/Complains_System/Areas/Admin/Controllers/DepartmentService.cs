using Complains_System.Catalog.Admin;
using Complains_System.Catalog.Admin.DepartmentManagement.Dtos;
using Complains_System.Catalog.Department;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Complains_System.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="admin")]
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
                return RedirectToAction("Index","HomePage");
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        [HttpGet("edit-department")]
        public async Task<IActionResult> editdepartment(int id)
        {
            var dep = await _departmentService.GetDepartment(id);
            return View(dep);
        }
        [HttpPost("editting-department")]
        public async Task<IActionResult> editdepartmentprocess(IFormCollection frm, int id)
        {
            var request = new EditDepartmentRequest()
            {
                email = frm["email"],
                phone = frm["phone"],
                name = frm["name"],
                id = id
            };
            var result = await _departmentService.EditDepartment(request);
            if (result > 0)
            {
                return Ok("OK");
            }
            return BadRequest();
        }
        [HttpGet("new-department")]
        public async Task<IActionResult> CreateDepartment()
        {
            return View();
        }
        [HttpPost("creating-department")]
        public async Task<IActionResult> CreateDepartmentprocess([FromForm] IFormCollection frm)
        {
            var request = new CreateRequest()
            {
                email = frm["email"],
                phone = frm["phone"],
                Name = frm["name"]
            };
           var result =  await _departmentService.CreateDepartment(request);
            if (result > 0)
            {
                return RedirectToAction("CreateDepartment");
            }
            return BadRequest();
        }

        [HttpGet("manage-department")]
        public async Task<IActionResult> manage_department()
        {
            var data = await _departmentService.GetListDepartments();
            return View(data);
        }
        [HttpGet("deleting-department")]
        public async Task<IActionResult> deleting_department(int id)
        {
            var data = await _departmentService.DeleteDepartment(id);
            return RedirectToAction("manage_department");
        }
    }
}
