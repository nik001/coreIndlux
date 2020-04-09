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
        static List<Computer> comps = new List<Computer>();
        static HomeController()
        {
            comps.Add(new Computer { Id = 1, Name = "Apple II", Company = "Apple", Year = 1977 });
            comps.Add(new Computer { Id = 2, Name = "Macintosh", Company = "Apple", Year = 1983 });
            comps.Add(new Computer { Id = 3, Name = "IBM PC", Company = "IBM", Year = 1981 });
            comps.Add(new Computer { Id = 4, Name = "Altair", Company = "MITS", Year = 1975 });
        }
        public ActionResult Index()
        {
            return View(comps);
        }
    
    }
}