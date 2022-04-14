using Complains_System.Catalog.Admin.ComplainsManagement;
using Complains_System.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Complains_System.Areas.Admin.Controllers
{
    [Route("/[controller]")]
    public class ComplainsService : Controller
    {
        private readonly IComplainsService _complainsService;
        public ComplainsService(IComplainsService complainsService)
        {
            _complainsService = complainsService;
        }

    }
}
