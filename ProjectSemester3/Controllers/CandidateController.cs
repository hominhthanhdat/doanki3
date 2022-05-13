using Microsoft.AspNetCore.Mvc;
using ProjectSemester3.Models;
using ProjectSemester3.Services;
using System.Diagnostics;

namespace ProjectSemester3.Controllers
{
    [Route("api/candidate")]
    public class CandidateController : Controller
    {
        private CandidateService candidateSer;
        public CandidateController(CandidateService candidateService)
        {
            candidateSer = candidateService;
        }

        [HttpGet("getAll")]
        [Consumes("application/json")]
        public IActionResult GetAll()
        {

            return Ok(candidateSer.GetAll());

        }
        [HttpGet("getByID/{id}")]
        [Consumes("application/json")]
        public IActionResult GetById(int id)
        {

            return Ok(candidateSer.GetById(id));

        }

        [HttpPost("add")]
        [Consumes("application/json")]
        [Produces("application/json")]
        public IActionResult Add([FromBody] Candidate candidate)
        {
            try
            {
                return Ok(candidateSer.Add(candidate));
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPut("edit")]
        [Consumes("application/json")]
        [Produces("application/json")]
        public IActionResult Edit([FromBody] Candidate candidate)
        {
            try
            {
                return Ok(candidateSer.Edit(candidate));
            }
            catch
            {
                return BadRequest();
            }
        }
        
    }
}
