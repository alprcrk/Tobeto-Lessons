using Business.Abstracts;
using Business.Dtos.Requests;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        ICourseService _courseSevice;
        public CoursesController(ICourseService courseSevice)
        {
            _courseSevice = courseSevice;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateCourseRequest course)
        {
            await _courseSevice.Add(course);
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _courseSevice.GetListAsync();
            return Ok(result);
        }
    }
}
