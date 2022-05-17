using Complains_System.Catalog;
using Complains_System.Catalog.Admin.ComplainsManagement;
using Complains_System.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Complains_System.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="admin")]
    public class ComplainsService : Controller
    {
        private readonly IComplainsService _complainsService;
        private readonly IComplainsManagement _complainsManage;

        public ComplainsService(IComplainsService complainsService, IComplainsManagement complainsManage)
        {
            _complainsService = complainsService;
            _complainsManage = complainsManage;
        }
        
        [Route("getlist", Name ="get-list-complains")]
        public async Task<IActionResult> GetlistComplains(int id, DateTime start, DateTime end, string Status)
        {
            if (start.Year <= 1975 || end.Year >= 9999)
            {
                start = Convert.ToDateTime("2020/01/01");
                end = DateTime.Now;
            }
            var request = new GetListRequest()
            {
                IdDep = id,
                startdate = start,
                enddate = end,
                Status = Status
            };
            var data = await _complainsService.GetListComplains(request);
            return View(data);
        }
        [Route("view-detail/{id}")]
        public async Task<IActionResult> viewdetailcomplains(int id)
        {
            var complains = await _complainsManage.GetbyId(id);
            if (complains == null)
            {
                return BadRequest("Cannot find Complains!");
            }
            return View(complains);
        }

    }
}
