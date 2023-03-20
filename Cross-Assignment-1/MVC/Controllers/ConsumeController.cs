using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Model;

namespace MVC.Controllers
{
    
    [Route("[controller]")]
    [Route("[controller]/[action]")]
    public class ConsumeController : Controller
    {
         private readonly Traineedb17Context _db;

         public ConsumeController(Traineedb17Context db)
         {
            
            _db=db;
         }

[HttpGet]
public IActionResult Index()
{
    
    return View();
}
       

   
      
    }
}