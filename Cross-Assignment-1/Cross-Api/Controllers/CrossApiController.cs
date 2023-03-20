using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model;

namespace Cross_Api.Controllers
{

   

    [ApiController]
    [Route("api/[controller]")]

   
    public class CrossApiController : ControllerBase
    {
          private readonly Traineedb17Context _db;

    public CrossApiController(Traineedb17Context db)
    {
        _db=db;
    }
    
    [HttpGet]
         public async Task<IActionResult>Get()
         {
            
            return Ok(_db.Crossdemos.ToList());
         } 
         [HttpPost]
         public async Task<IActionResult> Post(Crossdemo demo)
         {
            _db.Crossdemos.Add(demo);
            _db.SaveChanges();
            
            return Ok();
         }
         
      [HttpGet("{id}")]
         public async Task<IActionResult> get(int id)
         {
            var x=_db.Crossdemos.Find(id);
            
            return Ok(x);
         }
        
      //    [HttpGet("{name}")]
      // public async Task<IActionResult> Name(int id,string Name)
      //    {
      //        var x=_db.Crossdemos.Find(Name);
      //      // var x=_db.Crossdemos.FromSql($"select *from Crossdemos where name=Name").ToList();
              
      //       return Ok(x);
      //    }
        [HttpGet("name")]
        public async Task<IActionResult> Search(string name)
        {
         var x=_db.Crossdemos.Where(s=>s.Name==name).ToList();

         
       
            return Ok(x);
   
        
        }
        [HttpGet("SearchAll")]
        public async Task<IActionResult> SearchAll(string name,string sub)
        {
         var x=_db.Crossdemos.Where(s=>s.Name==name && s.Sub==sub).ToList();
         return Ok(x);
    }
         [HttpGet("sub")]
        public async Task<IActionResult> Searchbysub(string sub)
        {
         var x=_db.Crossdemos.Where(s=>s.Sub==sub).ToList();

         
       
            return Ok(x);
   
        
        }
         [HttpPut]
         public async Task<IActionResult> update(Crossdemo demo)
         {
             _db.Entry(demo).State=Microsoft.EntityFrameworkCore.EntityState.Modified;
            _db.SaveChanges();
            return Ok();
         }
[HttpDelete]
public async Task<IActionResult> Delete(int id)
{
    var x=_db.Crossdemos.Find(id);
    _db.Remove(x);
    _db.SaveChanges();
    return Ok();
}
   

    }
}