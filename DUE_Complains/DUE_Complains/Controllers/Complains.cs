using DUE_Complains.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DUE_Complains.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class Complains : Controller
    {
        private readonly IComplainsManagement _complainsManagement;
        public Complains(IComplainsManagement complainsManagement)
        {
            _complainsManagement = complainsManagement;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var complains = await _complainsManagement.GetAll();
            return Ok(complains);
        }
    }
}
