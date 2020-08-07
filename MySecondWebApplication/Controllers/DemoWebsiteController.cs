using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySecondWebApplication.Controllers
{
    [Route("demo")]
    public class DemoWebsiteController : Controller
    {
        [Route("show")]
        public IActionResult GetData()
        {

            return View("index");        
        }
    }
}
