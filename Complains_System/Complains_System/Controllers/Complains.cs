using Complains_System.Catalog;
using Complains_System.Catalog.Complains.management;
using Complains_System.Catalog.Department;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Threading.Tasks;

namespace Complains_System.Controllers
{
    [Route("/[controller]")]

    //[Authorize]
    public class Complains : Controller
    {
        private readonly IComplainsManagement _complainsManagement;
        private readonly IDepartmentService _departmentService;

        //private readonly Complains_DUEContext _context;

        public Complains(IComplainsManagement complainsManagement, IDepartmentService departmentService)
        {
            _complainsManagement = complainsManagement;
            _departmentService = departmentService;
        }

        [HttpGet("public-post")]
        public async Task<IActionResult> Get()
        {
            var complains = await _complainsManagement.GetAll();
            return Ok(complains);
        }

        [HttpPost("find-result")]
        public async Task<IActionResult> Get([FromQuery]GetComplainsPagingRequest request)
        {
            var complains = await _complainsManagement.GetAllbyKeyword(request);
            return Ok(complains);
        }

        [Authorize(Roles ="student")]
        [HttpPost("my-complains")]
        public async Task<IActionResult> Getmycomplain([FromQuery] GetComplainsPagingRequest request)
        {
            request.idStudent = TempData["id"].ToString();
            var complains = await _complainsManagement.GetAllbyKeyword(request);
            return View(complains);
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

        [Authorize(Roles = "student")]
        [HttpGet]
        public async Task<IActionResult> Create([FromForm] ComplainsCreateRequest request)
        {
            var ComplainID = await _complainsManagement.CreateDraft(request);

            if (ComplainID == 0)
            {
                return BadRequest();
            }
            var complain = await _complainsManagement.GetbyId(ComplainID);


            return Ok(complain);
        }

        [Authorize(Roles = "student")]
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

            if (ComplainID == 0)
            {
                return BadRequest();
            }
            var complain = await _complainsManagement.GetbyId(ComplainID);


            return Ok(complain);
        }

        [Authorize(Roles = "student")]
        [HttpGet("new-draft")]
        public async Task<IActionResult> NewDraft()
        {
            var data = await _departmentService.GetListDepartments();
           
            return View(data);
        }


        [Authorize(Roles = "student")]
        [HttpPut]
        public async Task<IActionResult> EditDraft([FromBody]EditDraftRequest request)
        {
            var EditedResult = await _complainsManagement.EditCraft(request);
            if (EditedResult == 0)
            {
                return BadRequest();
            }

            return Ok();
        }

        [Authorize(Roles = "employee")]
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


        [Authorize(Roles = "student")]
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
