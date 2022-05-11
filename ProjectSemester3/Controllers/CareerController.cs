using Microsoft.AspNetCore.Mvc;
using ProjectSemester3.Models;
using ProjectSemester3.Services;
using System.Diagnostics;

namespace ProjectSemester3.Controllers
{
    [Route("api/career")]
    public class CareerController : Controller
    {
        private CareerService careerSer;
        public CareerController(CareerService careerService)
        {
            careerSer = careerService;
        }

        [HttpGet("getByRange/{start}/{amount}")]
        [Consumes("application/json")]
        public IActionResult GetByRange(int start,int amount)
        {
           
                return Ok(careerSer.GetByRange(start,amount));

        }
        [HttpGet("getByID/{id}")]
        [Consumes("application/json")]
        public IActionResult GetById(int id)
        {

            return Ok(careerSer.GetByID(id));

        }

        [HttpPost("add")]
        [Consumes("application/json")]
        [Produces("application/json")]
        public IActionResult Add([FromBody] Career career)
        {
            try
            {
                return Ok(careerSer.AddCareer(career));
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPut("edit")]
        [Consumes("application/json")]
        [Produces("application/json")]
        public IActionResult Edit([FromBody] Career career)
        {
            try
            {
                return Ok(careerSer.EditCareer(career));
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpDelete("delete/{careerId}")]
        [Consumes("application/json")]
        [Produces("application/json")]
        public IActionResult Delete(int careerID)
        {
            try
            {
                return Ok(careerSer.DeleteCareer(careerID));
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
