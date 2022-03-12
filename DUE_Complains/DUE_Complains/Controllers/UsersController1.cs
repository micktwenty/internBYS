using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DUE_Complains.Controllers
{
    public class UsersController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
