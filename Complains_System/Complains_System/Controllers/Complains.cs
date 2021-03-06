using Complains_System.Catalog;
using Complains_System.Catalog.Complains.Dtos;
using Complains_System.Catalog.Complains.management;
using Complains_System.Catalog.Department;
using Complains_System.Catalog.User;
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

    public class Complains : Controller
    {
        private readonly IComplainsManagement _complainsManagement;
        private readonly IDepartmentService _departmentService;
        private readonly IUserService _userService;

        private readonly UserManager<AppUser> _usermanager;

        public Complains(IComplainsManagement complainsManagement, IDepartmentService departmentService, UserManager<AppUser> usermanager, IUserService userService)
        {
            _complainsManagement = complainsManagement;
            _departmentService = departmentService;
            _usermanager = usermanager;
            _userService = userService;
        }

        [HttpGet("public-post")]
        public async Task<IActionResult> Get()
        {
            var complains = await _complainsManagement.GetAll();
            return Ok(complains);
        }

        [HttpPost("find-result")]
        public async Task<IActionResult> Find(IFormCollection? frm)
        {
            var request = new GetComplainsPagingRequest()
            {
                keyword = frm["search"]
            };
           
            var complains = await _complainsManagement.GetAllbyKeyword(request);
            var result = complains.OrderByDescending(x => x.Date);
            return View(result);
        }



        [Authorize(Roles = "student")]
        [HttpGet("my-complains")]
        public async Task<IActionResult> Getmycomplain(GetComplainsPagingRequest request)
        {
            ClaimsPrincipal currentUser = this.User;
            if (currentUser.FindFirst(ClaimTypes.Name) != null)
            {
                var Name = currentUser.FindFirst(ClaimTypes.Name).Value;
                var user = _userService.getUser(Name);
                request.idStudent = user.Result.IdStudent;
            }
            else
            {
                return RedirectToAction("Login", "Users");
            }
            var complains = await _complainsManagement.GetOwnPaging(request);
            var pageNumber = request.page ?? 1;
            pageNumber = pageNumber == 0 ? 1 : pageNumber;
            var pageSize = 8;
            return View("Getmycomplain", complains.item.OrderByDescending(x => x.Date).ToPagedList(pageNumber, pageSize));

        }
        [Authorize(Roles = "student")]
        [HttpGet("my-complains/request")]
        public async Task<IActionResult> Getmyrequestcomplain(GetComplainsPagingRequest request)
        {
            ClaimsPrincipal currentUser = this.User;
            if (currentUser.FindFirst(ClaimTypes.Name) != null)
            {
                var Name = currentUser.FindFirst(ClaimTypes.Name).Value;
                var user = _userService.getUser(Name);
                request.idStudent = user.Result.IdStudent;
                request.status = "Chờ duyệt";
            }
            else
            {
                return RedirectToAction("Login", "Users");
            }
            var complains = await _complainsManagement.GetOwnPaging(request);
            var pageNumber = request.page ?? 1;
            //pageNumber = pageNumber == 0 ? 1 : pageNumber;
            var pageSize = 6;
            return View("Getmycomplain", complains.item.OrderByDescending(x => x.Date).ToPagedList(pageNumber, pageSize));

        }

        [Authorize(Roles = "student")]
        [HttpGet("my-complains/deny")]
        public async Task<IActionResult> Getmydenycomplain( GetComplainsPagingRequest request)
        {
            ClaimsPrincipal currentUser = this.User;
            if (currentUser.FindFirst(ClaimTypes.Name) != null)
            {
                var Name = currentUser.FindFirst(ClaimTypes.Name).Value;
                var user = _userService.getUser(Name);
                request.idStudent = user.Result.IdStudent;
                request.status = "Từ chối giải quyết";
            }
            else
            {
                return RedirectToAction("Login", "Users");
            }
            var complains = await _complainsManagement.GetOwnPaging(request);
            var pageNumber = request.page ?? 1;
            //pageNumber = pageNumber == 0 ? 1 : pageNumber;
            var pageSize = 6;
            return View("Getmycomplain", complains.item.OrderByDescending(x => x.Date).ToPagedList(pageNumber, pageSize));

        }

        [Authorize(Roles = "student")]
        [HttpGet("my-complains/spam")]
        public async Task<IActionResult> Getmyspamcomplain(GetComplainsPagingRequest request)
        {
            ClaimsPrincipal currentUser = this.User;
            if (currentUser.FindFirst(ClaimTypes.Name) != null)
            {
                var Name = currentUser.FindFirst(ClaimTypes.Name).Value;
                var user = _userService.getUser(Name);
                request.idStudent = user.Result.IdStudent;
                request.status = "spam";
            }
            else
            {
                return RedirectToAction("Login", "Users");
            }
            var complains = await _complainsManagement.GetOwnPaging(request);
            var pageNumber = request.page ?? 1;
            //pageNumber = pageNumber == 0 ? 1 : pageNumber;
            var pageSize = 6;
            return View("Getmycomplain", complains.item.OrderByDescending(x => x.Date).ToPagedList(pageNumber, pageSize));

        }

        [Authorize(Roles = "student")]
        [HttpGet("my-complains/draft")]
        public async Task<IActionResult> Getmydraftcomplain(GetComplainsPagingRequest request)
        {
            ClaimsPrincipal currentUser = this.User;
            if (currentUser.FindFirst(ClaimTypes.Name) != null)
            {
                var Name = currentUser.FindFirst(ClaimTypes.Name).Value;
                var user = _userService.getUser(Name);
                request.idStudent = user.Result.IdStudent;
                request.status = "Bản nháp";
            }
            else
            {
                return RedirectToAction("Login", "Users");
            }
            var complains = await _complainsManagement.GetOwnPaging(request);
            var pageNumber = request.page ?? 1;
            //pageNumber = pageNumber == 0 ? 1 : pageNumber;
            var pageSize = 6;
            return View("ListDraft", complains.item.OrderByDescending(x => x.Date).ToPagedList(pageNumber, pageSize));

        }

        [Authorize(Roles = "student")]
        [HttpGet("my-complains/done")]
        public async Task<IActionResult> Getmydonecomplain( GetComplainsPagingRequest request)
        {
            ClaimsPrincipal currentUser = this.User;
            if (currentUser.FindFirst(ClaimTypes.Name) != null)
            {
                var Name = currentUser.FindFirst(ClaimTypes.Name).Value;
                var user = _userService.getUser(Name);
                request.idStudent = user.Result.IdStudent;
                request.status = "Đã duyệt!";
            }
            else
            {
                return RedirectToAction("Login", "Users");
            }
            var complains = await _complainsManagement.GetOwnPaging(request);
            var pageNumber = request.page ?? 1;
            var pageSize = 6;
            return View("Getmycomplain",complains.item.OrderByDescending(x => x.Date).ToPagedList(pageNumber, pageSize));
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

        [HttpGet("viewdetail")]
        public async Task<IActionResult> viewdetail(int id)
        {
            var complains = await _complainsManagement.GetbyId(id);
            if (complains == null)
            {
                return BadRequest("Cannot find Complains!");
            }                
            if (complains.IsPublic == true || complains.IdStudent == _usermanager.GetUserName(this.User))
            {
                return View(complains);
            }
            return BadRequest("Cannot find Complains!");
        }

        [Authorize(Roles = "student")]
        [HttpGet("editdraft")]
        public async Task<IActionResult> editdraft(int id)
        {
            var complains = await _complainsManagement.GetbyId(id);
            var data = await _departmentService.GetListDepartments();
            ViewBag.khoa = data;
            if (complains == null)
            {
                return BadRequest("Cannot find Complains!");
            }
            if (complains.IsPublic == true || complains.IdStudent == _usermanager.GetUserName(this.User))
            {
                return View(complains);
            }
            return BadRequest("Cannot find Complains!");
        }

        [Authorize(Roles = "employee")]
        [HttpGet("reply-post")]
        public async Task<IActionResult> replyview(string id)
        {
            var complains = await _complainsManagement.GetbyId(Convert.ToInt32(id));
            if (complains == null || complains.Status != "Chờ duyệt")
            {
                return BadRequest("Cannot find Complains!");
            }
            return View(complains);
        }


        [Authorize(Roles = "student")]
        [HttpPost("create-draft")]
        public async Task<IActionResult> CreateDraft(IFormCollection frm)
        {
            var request = new ComplainsCreateRequest();
            request.Content = frm["content"];
            request.Title = frm["tieude"];
            var user = _userService.getUser(_usermanager.GetUserName(User));
            request.IdStudent = user.Result.IdStudent;
            if (frm.Files.Count > 0)
            {
                request.ThumbnailImage = frm.Files[0];
            }
            request.IdDepartment = Convert.ToInt32(frm["khoa"]);
            var ComplainID = await _complainsManagement.CreateDraft(request);
            if (ComplainID == "0")
            {
                return BadRequest();
            }
            var complain = await _complainsManagement.GetbyId(Convert.ToInt32(ComplainID));
            return RedirectToAction("Getmydraftcomplain");
        }

        [Authorize(Roles = "employee")]
        [HttpPost("Spaming-post")]
        public async Task<IActionResult> SpamPost(IFormCollection frm, string id)
        {
            var reply = frm["content"].ToString();
            var user = _userService.getUser(_usermanager.GetUserName(this.User));
            var ComplainID = await _complainsManagement.SpamPost(reply,Convert.ToInt32(id),user.Result.idteacher);
            if (ComplainID == 0)
            {
                return BadRequest();
            }
            return RedirectToAction("GetRequestList");
        }

        [Authorize(Roles = "student")]
        [HttpPost]
        public async Task<IActionResult> RequestPosting(IFormCollection frm)
        {
            var request = new ComplainsCreateRequest();
            request.Content = frm["content"];
            request.Title = frm["tieude"];
            var user = _userService.getUser(_usermanager.GetUserName(User));
            request.IdStudent = user.Result.IdStudent;
            if (frm.Files.Count > 0)
            {
                request.ThumbnailImage = frm.Files[0];
            }
            request.IdDepartment = Convert.ToInt32( frm["khoa"]);
            var ComplainID = await _complainsManagement.PostRequest(request);

            if (ComplainID == "0")
            {
                return BadRequest();
            }
            var complain = await _complainsManagement.GetbyId(Convert.ToInt32(ComplainID));
            return View("viewdetail",complain);
        }

        [Authorize(Roles = "student")]
        [HttpGet("new-draft")]
        public async Task<IActionResult> NewDraft()
        {
            var data = await _departmentService.GetListDepartments();
            return View(data);
        }

        [Authorize(Roles = "employee")]
        [HttpGet("request-post-list")]
        public async Task<IActionResult> GetRequestList(int? page)
        {
            var user = _userService.getUser(_usermanager.GetUserName(User));
            var data = await _complainsManagement.GetRequestPost(user.Result.IdDepartment);
            var pageNumber = page ?? 1;
            //pageNumber = pageNumber == 0 ? 1 : pageNumber;
            var pageSize = 10;
            return View(data.ToPagedList(pageNumber, pageSize));
        }
        //[Authorize(Roles = "student")]
        [HttpPut]
        public async Task<IActionResult> EditDraft([FromBody]EditDraftRequest request)
        {
            var EditedResult = await _complainsManagement.EditDraft(request);
            if (EditedResult == "0")
            {
                return BadRequest();
            }
            var complain = await _complainsManagement.GetbyId(Convert.ToInt32(EditedResult));
            return View("viewdetail", complain);
        }

        [Authorize(Roles = "employee")]
        [HttpPost("reply/{id}")]
        public async Task<IActionResult> ReplyComplain(IFormCollection frm, string id)
        {
            var user = _userService.getUser(_usermanager.GetUserName(this.User));
            var reply = frm["content"];
            var emp = user.Result.idteacher;
            var Result = await _complainsManagement.ReplyComplain(reply,Convert.ToInt32(id),emp);
            if (Result == 0)
            {
                return BadRequest();
            }

            return RedirectToAction("GetRequestList");
        }

        [HttpPost("deny/{id}")]
        public async Task<IActionResult> DenyPost(IFormCollection frm, string id)
        {
            var user = _userService.getUser(_usermanager.GetUserName(this.User));
            var reply = frm["content"];
            var emp = user.Result.idteacher;
            var Result = await _complainsManagement.DenyPost(reply, Convert.ToInt32(id), emp);
            if (Result == 0)
            {
                return BadRequest();
            }

            return RedirectToAction("GetRequestList");
        }


        //[Authorize(Roles = "student")]
        [HttpGet("delete/{id}")]
        public async Task<IActionResult> DeleteDraft(int Id)
        {
            var EditedResult = await _complainsManagement.Delete(Id);
            if (EditedResult == 0)
            {
                return BadRequest();
            }

            return RedirectToAction("Getmyspamcomplain");
        }
    }
}
