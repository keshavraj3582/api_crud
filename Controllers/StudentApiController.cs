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
      /// <summary>
      /// Get All Student Data
      /// </summary>
      /// <returns>
      ///   200 OK with a list of student data if students are found.
      ///   404 Not Found if no students are found.
      /// </returns>
      [HttpGet]
      [ProducesResponseType(StatusCodes.Status200OK)] // Documenting the success response
      [ProducesResponseType(StatusCodes.Status404NotFound)] // Documenting the error response
      [ProducesResponseType(StatusCodes.Status400BadRequest)]
     public async Task<ActionResult<List<Student>>> GetStudents()
     {
        var data=await context.Students.ToListAsync();
        return Ok(data);
     } 
      /// <summary>
      /// Get the Particular Data Of Student by their Respective <paramref name="id"/>
      /// </summary>
      /// <param name="id">The ID of the student to retrieve.</param>
      /// <returns>
      ///   200 OK with the student data if the student is found.
      ///   404 Not Found if the student with the given ID is not found.
      /// </returns>
      [HttpGet("{id}")]
      [ProducesResponseType(StatusCodes.Status200OK)] // Documenting the success response
      [ProducesResponseType(StatusCodes.Status404NotFound)] // Documenting the error response
      [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Student>> GetStudentsById(string id)
     {   
        var student=await context.Students.FindAsync(id);
        if(student==null)
        {
         return NotFound();
        }
        return student;
     }
      /// <summary>
      /// Create a New Student with Data
      /// </summary>
      /// <param name="std">The student data to create.</param>
      /// <returns>
      ///   201 Created if the student is successfully created.
      ///   400 Bad Request if there are validation errors or other issues with the request.
      /// </returns>
      [HttpPost]
      [ProducesResponseType(StatusCodes.Status201Created)] // Documenting the success response
      [ProducesResponseType(StatusCodes.Status400BadRequest)] // Documenting the error response

     public async Task<ActionResult<Student>> CreateStudent(Student std)
     {
            if (std == null)
            {
                return BadRequest("Invalid student data.");
            }

            try
            {
                await context.Students.AddAsync(std);
                await context.SaveChangesAsync();
                return Ok(std);
            }
            catch (Exception ex)
            {
                
                return StatusCode(400, $"An error occurred : {ex.Message}");
            }
            // await context.Students.AddAsync(std);
            //await context.SaveChangesAsync();
            //return Ok(std);
        }
      /// <summary>
      /// Update the Data of Existing Student by <paramref name="id"/>
      /// </summary>
      /// <param name="id">The ID of the student to update.</param>
      /// <param name="std">The updated student data.</param>
      /// <returns>
      ///   200 OK if the student is successfully updated.
      ///   400 Bad Request if the provided ID in the URL does not match the student's ID.
      /// </returns>
      [HttpPut("{id}")]
      [ProducesResponseType(StatusCodes.Status200OK)] // Documenting the success response
      [ProducesResponseType(StatusCodes.Status400BadRequest)] // Documenting the error response

        public async Task<ActionResult<Student>> UpdateStudent(string id, Student std)
     { 
        if(id!=std.StudentId)
        {
         return BadRequest("Student Id not Found");
        }
        context.Entry(std).State=EntityState.Modified;
        await context.SaveChangesAsync();
        return Ok(std);
     }
      /// <summary>
      /// Delete Student Data By <paramref name="id"/>
      /// </summary>
      /// <param name="id">The ID of the student to delete.</param>
      /// <returns>
      ///   200 OK if the student is successfully deleted.
      ///   404 Not Found if the student with the given ID is not found.
      /// </returns>
      [HttpDelete("{id}")]
      [ProducesResponseType(StatusCodes.Status200OK)] // Documenting the success response
      [ProducesResponseType(StatusCodes.Status404NotFound)] // Documenting the error response
     public async Task<ActionResult<Student>> DeleteStudent(string id)
     {   
        var std=await context.Students.FindAsync(id);
        if(std==null)
        {
         return NotFound("Student Not Found");
        }
        context.Students.Remove(std);
        await context.SaveChangesAsync();
        return Ok(std);
     }  
    }
    //conditional class
    

}