using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Herhaling1.Controllers
{
    [Route("")]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [Route("")]
        [Route("[action]")]
        public IActionResult Index()
        {
            return View();
        }
        
        [Route("[action]")]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        [Route("[action]")]
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        [Route("[action]")]
        public IActionResult Error()
        {
            return View();
        }
    }
}
