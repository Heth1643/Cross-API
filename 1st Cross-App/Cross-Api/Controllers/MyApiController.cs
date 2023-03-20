using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Cross_Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MyApiController : ControllerBase
    {
         [HttpGet]
       public string getstring()
       {
        return "This is demostration for Cross-Api";
       } 

    }
}