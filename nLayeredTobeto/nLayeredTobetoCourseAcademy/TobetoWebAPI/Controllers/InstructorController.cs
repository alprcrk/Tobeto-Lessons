using Business.Abstracts;
using Business.Dtos.Requests;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorController : ControllerBase
    {
        IInstructorService _instructorSevice;
        public InstructorController(IInstructorService instructorSevice)
        {
            _instructorSevice = instructorSevice;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateInstructorRequest instructor)
        {
           var result =  await _instructorSevice.Add(instructor);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _instructorSevice.GetListAsync();
            return Ok(result);
        }
    }
}
