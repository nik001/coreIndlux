using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using web_Core.Models;

namespace web_Core.Controllers
{
    public class HomeController : Controller
    {
        static HomeController()
        {
;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Authorization()
        {
            return View();
        }
        public ActionResult HelpDesk()
        {
            return View();
        }

    }
}