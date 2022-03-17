﻿using Complains_System.Catalog;
using Complains_System.Catalog.Complains.management;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Complains_System.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    //[Authorize]
    public class Complains : Controller
    {
        private readonly IComplainsManagement _complainsManagement;
        //private readonly Complains_DUEContext _context;

        public Complains(IComplainsManagement complainsManagement)
        {
            _complainsManagement = complainsManagement;
            //_context = context;
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

        [HttpPost]
        public async Task<IActionResult> Create([FromForm]ComplainsCreateRequest request)
        {
            var ComplainID = await _complainsManagement.CreateDraft(request);
            
            if (ComplainID == 0)
            {
                return BadRequest();
            }
            var complain = await _complainsManagement.GetbyId(ComplainID);
           

            return Ok(complain);
        }

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
