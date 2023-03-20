using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Cross_apiConsume.Controllers
{
    [Route("[controller]")]
    public class AllController : Controller
    {
       

        [HttpGet]
        public IActionResult Index() {
         return View();
        }

    }
}