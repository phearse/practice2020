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
    [Route("api/Teachers")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private readonly TeachersContext _context;
        public TeachersController(TeachersContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetTeachers()
        {
            var teacher = _context.Teachers.ToList();
            return Ok(teacher);
        }

        [HttpGet("{id}")]
        public IActionResult GetTeachersbyId(int id)
        {
            var teacher = _context.Teachers.Find(id);
            if (teacher == null)
            {
                return NotFound();
            }
            return Ok(teacher);
        }

        [HttpPost("{id}/{name}")]
        public IActionResult PostTeachers( int id, string name)
        {
            var teacher = new Teachers()
            {
                te_id = id,
                te_name = name
            };
            _context.Add(teacher);
            _context.SaveChanges();
            return Ok("Created");
        }

        [HttpPut("{id}/{id2}/{rename}")]
        public IActionResult PutTeachers(int id, int id2, string rename)
        {
            var teacher = _context.Teachers.Find(id);
            if (teacher == null)
            {
                return NotFound();
            }
            teacher.te_name = rename;
            teacher.de_id = id2;
            _context.Teachers.Update(teacher);
            _context.SaveChanges();
            return Ok("Update");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTeachers(int id)
        {
            var teacher = _context.Teachers.Find(id);
            if (teacher == null)
            {
                return NotFound();
            }
            _context.Teachers.Remove(teacher);
            _context.SaveChanges();
            return Ok("Deleted");
        }
    }
}

