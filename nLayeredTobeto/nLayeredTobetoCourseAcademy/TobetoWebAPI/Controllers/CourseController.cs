using Business.Abstracts;
using Business.Dtos.Requests;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        ICourseService _courseSevice;
        public CourseController(ICourseService courseSevice)
        {
            _courseSevice = courseSevice;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateCourseRequest course)
        {
            var result = await _courseSevice.Add(course);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _courseSevice.GetListAsync();
            return Ok(result);
        }
    }
}
