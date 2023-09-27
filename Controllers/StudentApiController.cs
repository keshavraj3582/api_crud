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
    }

}