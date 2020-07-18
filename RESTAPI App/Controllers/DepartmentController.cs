using System;
using System.Collections.Generic;
using System.Composition;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using Practice.Models;


namespace Practice.Controllers
{
    [Route("api/Department")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly DepartmentContext _context;
        public DepartmentController(DepartmentContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetDepartment()
        {
            var club = _context.Department.ToList();
            return Ok(club);
        }

        [HttpGet("{id}")]
        public IActionResult GetDepartmentbyId(int id)
        {
            var club = _context.Department.Find(id);
            if (club == null)
            {
                return NotFound();
            }
            return Ok(club);
        }

        [HttpPost("{name}")]
        public IActionResult PostDepartment(string name)
        {
            var department = new Department()
            {
                de_tittle = name
            };
            _context.Add(department);
            _context.SaveChanges();
            return Ok("Created");
        }

        [HttpPut("{id}/{rename}")]
        public IActionResult PutClub(int id, string rename)
        {
            var department = _context.Department.Find(id);
            if (department == null)
            {
                return NotFound();
            }
            department.de_tittle = rename;
            _context.Department.Update(department);
            _context.SaveChanges();
            return Ok("Update");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteClub(int id)
        {
            var department = _context.Department.Find(id);
            if (department == null)
            {
                return NotFound();
            }
            _context.Department.Remove(department);
            _context.SaveChanges();
            return Ok("Deleted");
        }
    }
}

