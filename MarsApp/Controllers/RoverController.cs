using MarsApp.Entities;
using MarsApp.Repository;
using Microsoft.AspNetCore.Mvc;

namespace MarsApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoverController : ControllerBase
    {

        private readonly IMarsAppRepository _methods;
        public RoverController(IMarsAppRepository methods)
        {
            _methods = methods;
        }

        [HttpGet("{roverID}", Name = "GetRover")]
        public IActionResult GetRover(int id)
        {
            try
            {
                _methods.GetRover(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpPost]
        public ActionResult<RoverEntity> GenerateRover(RoverEntity rover)
        {
            try
            {
                _methods.CreateRover(rover);
                _methods.Save();
                return CreatedAtRoute("GetRover", new { id = rover.RoverID }, rover);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException);
            }
        }
    }
}
