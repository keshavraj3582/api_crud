using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using web_api_crud.Models;
namespace web_api_crud.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class StudentApiController:ControllerBase
    {
        private readonly ApiStudentDatabaseContext context;
     public StudentApiController(ApiStudentDatabaseContext context)
     {
        this.context=context;
     }
     [HttpGet]
     public async Task<ActionResult<List<Student>>> GetStudents()
     {
        var data=await context.Students.ToListAsync();
        return Ok(data);
     } 
      [HttpGet("{id}")]
     public async Task<ActionResult<Student>> GetStudentsById(string id)
     {   
        var student=await context.Students.FindAsync(id);
        if(student==null)
        {
         return NotFound();
        }
        return student;
     }
      [HttpPost]
     public async Task<ActionResult<Student>> CreateStudent(Student std)
     {   
        await context.Students.AddAsync(std);
        await context.SaveChangesAsync();
        return Ok(std);
     }
      [HttpPut("{id}")]
     public async Task<ActionResult<Student>> UpdateStudent(string id, Student std)
     {   
        if(id!=std.StudentId)
        {
         return BadRequest();
        }
        context.Entry(std).State=EntityState.Modified;
        await context.SaveChangesAsync();
        return Ok(std);
     }
      [HttpDelete("{id}")]
     public async Task<ActionResult<Student>> DeleteStudent(string id)
     {   
        var std=await context.Students.FindAsync(id);
        if(std==null)
        {
         return NotFound();
        }
        context.Students.Remove(std);
        await context.SaveChangesAsync();
        return Ok();
     }  
    }

}