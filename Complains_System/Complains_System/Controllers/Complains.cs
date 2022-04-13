using Complains_System.Catalog;
using Complains_System.Catalog.Complains.management;
using Complains_System.Catalog.Department;
using Complains_System.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using X.PagedList;

namespace Complains_System.Controllers
{
    [Route("/[controller]")]

    //[Authorize]
    public class Complains : Controller
    {
        private readonly IComplainsManagement _complainsManagement;
        private readonly IDepartmentService _departmentService;
        private readonly UserManager<AppUser> _usermanager;
        //private readonly Complains_DUEContext _context;

        public Complains(IComplainsManagement complainsManagement, IDepartmentService departmentService, UserManager<AppUser> usermanager)
        {
            _complainsManagement = complainsManagement;
            _departmentService = departmentService;
            _usermanager = usermanager;
        }

        [HttpGet("public-post")]
        public async Task<IActionResult> Get()
        {
            var complains = await _complainsManagement.GetAll();
            return Ok(complains);
        }

        [HttpPost("find-result")]
        public async Task<IActionResult> Get(GetComplainsPagingRequest request)
        {
            var complains = await _complainsManagement.GetAllbyKeyword(request);
            return Ok(complains);
        }


        [HttpGet("my-complains")]
        public async Task<IActionResult> Getmycomplain([FromQuery] GetComplainsPagingRequest request)
        {
            ClaimsPrincipal currentUser = this.User;
            if (currentUser.FindFirst(ClaimTypes.Name) != null)
            {
                var Name = currentUser.FindFirst(ClaimTypes.Name).Value;
                var user = await _usermanager.FindByNameAsync(Name);
                request.idStudent = user.IdStudent;
            }
            var complains = await _complainsManagement.GetOwnPaging(request);
            var pageNumber = request.page ?? 1;
            //pageNumber = pageNumber == 0 ? 1 : pageNumber;
            var pageSize = 6;
            return View(complains.item.OrderByDescending(x => x.Date).ToPagedList(pageNumber, pageSize));
        }

        [HttpGet("{IdComplain}")]
        public async Task<IActionResult> GetbyID(int IdComplain)
        {
            var complains = await _complainsManagement.GetbyId(IdComplain);
            if (complains == null)
            {
                return BadRequest("Cannot find Complains!");
            }
            return Ok(complains);
        }
        [HttpGet("viewdetail/{id}")]
        public async Task<IActionResult> viewdetail(int id)
        {
            var complains = await _complainsManagement.GetbyId(id);
            if (complains == null)
            {
                return BadRequest("Cannot find Complains!");
            }
            return View(complains);
        }

        //[Authorize(Roles = "student")]
        [HttpGet]
        public async Task<IActionResult> Create([FromForm] ComplainsCreateRequest request)
        {
            var ComplainID = await _complainsManagement.CreateDraft(request);

            if (ComplainID == "0")
            {
                return BadRequest();
            }
            var complain = await _complainsManagement.GetbyId(Convert.ToInt32(ComplainID));


            return Ok(complain);
        }

        //[Authorize(Roles = "student")]
        [HttpPost]
        public async Task<IActionResult> RequestPosting(IFormCollection frm, IFormFile file)
        {
            var request = new ComplainsCreateRequest();
            request.Content = frm["content"];
            request.Title = frm["tieude"];
            request.IdStudent = TempData["id"].ToString();
            request.ThumbnailImage = frm.Files[0];
            request.IdDepartment = Convert.ToInt32( frm["khoa"]);

            var ComplainID = await _complainsManagement.CreateDraft(request);

            if (ComplainID == "0")
            {
                return BadRequest();
            }
            var complain = await _complainsManagement.GetbyId(Convert.ToInt32(ComplainID));


            return Ok(complain);
        }

        //[Authorize(Roles = "student")]
        [HttpGet("new-draft")]
        public async Task<IActionResult> NewDraft()
        {
            var data = await _departmentService.GetListDepartments();
           
            return View(data);
        }


        //[Authorize(Roles = "student")]
        [HttpPut]
        public async Task<IActionResult> EditDraft([FromBody]EditDraftRequest request)
        {
            var EditedResult = await _complainsManagement.EditCraft(request);
            if (EditedResult == "0")
            {
                return BadRequest();
            }

            return Ok();
        }

        //[Authorize(Roles = "employee")]
        [HttpPut("reply/{IdCom}")]
        public async Task<IActionResult> ReplyComplain([FromQuery]string reply, int IdCom, int emp)
        {
            var Result = await _complainsManagement.ReplyComplain(reply,IdCom,emp);
            if (Result == 0)
            {
                return BadRequest();
            }

            return Ok();
        }


        //[Authorize(Roles = "student")]
        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteDraft(int Id)
        {
            var EditedResult = await _complainsManagement.Delete(Id);
            if (EditedResult == 0)
            {
                return BadRequest();
            }

            return Ok();
        }
    }
}
