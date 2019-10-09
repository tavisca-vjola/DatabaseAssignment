using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Controllers.Models;
using RepositoryPattern.RepositoryLayer;
using Serilog;

namespace RepositoryPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IRepository _service;

        public StudentsController(IRepository service)
        {
            _service = service;
        }

        // GET: api/Students
        [HttpGet]
        public IEnumerable<Student> Getstudent()
        {
            Log.Information("Retrieved Student List");
            return _service.GetAllStudents();
        }
      
        
        // POST: api/Students
        [HttpPost]
        public void PostStudent([FromBody]Student student)
        {
            Log.Information("Student List created");
            _service.CreateStudents(student);
        }

      
    }
}
