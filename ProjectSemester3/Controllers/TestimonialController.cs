using Microsoft.AspNetCore.Mvc;
using ProjectSemester3.Models;
using ProjectSemester3.Services;
using System.Diagnostics;

namespace ProjectSemester3.Controllers
{
    [Route("api/testimonial")]
    public class TestimonialController : Controller
    {
        private TestimonialService testimonialSer;
        public TestimonialController(TestimonialService testimonialService)
        {
            testimonialSer = testimonialService;
        }

        [HttpGet("getAll")]
        [Consumes("application/json")]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(testimonialSer.GetAll());
            }
            catch
            {
                return BadRequest();
            }

        }
      
    }
}
