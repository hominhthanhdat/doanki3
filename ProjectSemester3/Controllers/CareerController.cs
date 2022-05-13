﻿using Microsoft.AspNetCore.Mvc;
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

        [HttpGet("getAll")]
        [Consumes("application/json")]
        public IActionResult GetAll()
        {

            return Ok(careerSer.GetAll());

        }
        [HttpGet("getByID/{id}")]
        [Consumes("application/json")]
        public IActionResult GetById(int id)
        {

            return Ok(careerSer.GetById(id));

        }

        [HttpPost("add")]
        [Consumes("application/json")]
        [Produces("application/json")]
        public IActionResult Add([FromBody] Career career)
        {
            try
            {
                return Ok(careerSer.Add(career));
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
                return Ok(careerSer.Edit(career));
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
                return Ok(careerSer.Delete(careerID));
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
