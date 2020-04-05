using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cwiczenie3.DAL;
using Cwiczenie3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cwiczenie3.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {
        private readonly IDbService _dbService;

        public StudentsController(IDbService dbService)
        {
            _dbService = dbService;
        }
        [HttpGet]
        public IActionResult GetStudents(string orderBy)
        {
            return Ok(_dbService.GetStudents());
        }

        //private IActionResult Ok(Func<IEnumerable<Student>> getStudents) => throw new NotImplementedException();

        /*
[HttpGet]
public string GetStudent()
{
   return "Kowalski, Malewski, Andrzejewski";
}
*/
        /*
        [HttpGet("{id}")]
        public IActionResult GetOneStudent(int id)
        {
            if (id == 1)
            {
                return Ok("Kowalski");
            }else if(id == 2)
            {
                return Ok("Malewski");
            }
            return NotFound("Nie znaleziono");
        }
        */

        /*
        [HttpGet("{orderBy}")]
        public string GetStudents(string orderBy)
        {
            return $"Kowalski, Malewski, Andrzejewski sortowanie={orderBy}";
        }
        */
        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            //... add to database
            //... generating index number
            student.IndexNumber = $"s{new Random().Next(1, 20000)}";
            return Ok(student);
        }
        [HttpPut("{idStudent}")]
        public IActionResult EditStudent(Student student, int idStudent)
        {
            //find from database student with given id
            //edit parameters with student's data
            //save to database
            return Ok("edycja zakończona");
        }
        [HttpDelete("{idStudent}")]
        public IActionResult DeleteStudent(int idStudent)
        {
            //find from database student with given id
            //drop record from database
            return Ok("usuwanie zakończone");
        }


    }
}