using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace Cross_Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class exApiController : ControllerBase
    {
     
          private readonly Traineedb17Context _db;

    public exApiController(Traineedb17Context db)
    {
        _db=db;
    }

        
    }
}