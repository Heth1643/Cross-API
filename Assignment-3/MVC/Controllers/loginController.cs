using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MVC.Controllers
{
    [Route("[controller]")]
      [Route("[controller]/[action]")]
    public class loginController : Controller
    {
       

        public IActionResult Login()
        {
            return View();
        }

public IActionResult Profile()
{
    
    return View();
}
      
        
    }
}