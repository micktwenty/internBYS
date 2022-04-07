using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Complains_System.Controllers
{
    public class Account : Controller
    {
        public ActionResult AccessDenied()
        {
            return View("UserAccessDenied");
        }
        public ActionResult Login()
        {
            return RedirectToAction("Login", "Users");
        }
    }
}
