using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model;
using viewmodel;

namespace Web_Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeApiController : ControllerBase
    {
        private readonly Traineedb17Context _db;

        public EmployeeApiController(Traineedb17Context db)
        {
            _db = db;
        }
        [HttpGet]
        public async Task<IActionResult> GetEmployee()
        {
           var x=from e in _db.Employee1s
       join d in _db.Department1s
        on  e.DeptId
        equals d.Id
         orderby e.EmpId
         select new
         {
                e.EmpId,
                e.EmpName,
                d.DeptName,
                e.Salary
            
        };

            return Ok(x);
        }


        [HttpGet("EmpId")]

        public async Task<IActionResult> GetbyId(int id)
        {
           
             var x=from e in _db.Employee1s
       join d in _db.Department1s
        on  e.DeptId
        equals d.Id
        where(e.EmpId==id)
         orderby e.EmpId
         select new
         {
                e.EmpId,
                e.EmpName,
                d.DeptName,
                e.Salary
            
        };

            return Ok(x);
        }
        [HttpGet("all")]
        public async Task<IActionResult> Alldate(int id)
        {
            var x=_db.Employee1s.Find(id);
            return Ok(x);
        }
          [HttpGet("byname")]
public async Task<IActionResult> databyname(string name)
        {
           var x=from e in _db.Employee1s
       join d in _db.Department1s
        on  e.DeptId
        equals d.Id
        where(e.EmpName==name)
         orderby e.EmpId
         select new
         {
                e.EmpId,
                e.EmpName,
                d.DeptName,
                e.Salary
            
        };
        return Ok(x);
        }
         [HttpGet("bydept")]
public async Task<IActionResult> databydept(string deptname)
        {
           var x=from e in _db.Employee1s
       join d in _db.Department1s
        on  e.DeptId
        equals d.Id
        where(d.DeptName==deptname)
         orderby e.EmpId
         select new
         {
                e.EmpId,
                e.EmpName,
                d.DeptName,
                e.Salary
            
        };
        return Ok(x);
        }
        [HttpPost]
        public async Task<IActionResult> PostData(Employee1 emp)
        {
            _db.Employee1s.Add(emp);
            _db.SaveChanges();
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> PutData(Employee1 emp)
        {

            _db.Entry(emp).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _db.SaveChanges();
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> Deletedata(int id)
        {
            var x = _db.Employee1s.Find(id);
            _db.Employee1s.Remove(x);
            _db.SaveChanges();
            return Ok();
        }
                
[HttpGet("dept")]
public async Task<IActionResult> GetDept()
{
   
var q = from e in _db.Employee1s
       join d in _db.Department1s
        on  e.DeptId
        equals d.Id 
         group e by new {d.DeptName} into g
         select new  
          {
                Department= g.Key.DeptName,
                Total=g.Count(),
               Salary=g.Sum(x=>x.Salary)
      
      };
     return Ok(q);
  
    }
    [HttpGet("department")]
    public async Task<IActionResult> GetDepartment()
    {
         var x=from s in _db.Department1s
            select new
            {
                s.Id,
              s.DeptName

            };
           return Ok(x);
    }
    [HttpPost("detpdata")]
    public async Task<IActionResult> PostDept(Department1 dept)
    {
         
        var x=_db.Department1s.Add(dept);
        _db.SaveChanges();
        return Ok(x);
    }
   
}}