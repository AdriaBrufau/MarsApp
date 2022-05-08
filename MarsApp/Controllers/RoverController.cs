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

        [HttpGet("{ID}", Name = "GetRover")]
        public ActionResult<RoverEntity> GetRover(int ID)
        {
            try
            {
                var entity = _methods.GetRover(ID);
                return Ok(entity);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpPost]
        public ActionResult<RoverEntity> GenerateRover([FromBody] RoverEntity rover)
        {
            try
            {
                _methods.CreateRover(rover);
                return Ok(rover);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpGet]
        public ActionResult<IEnumerable<RoverEntity>> GetRovers()
        {
            try
            {
                var entities = _methods.GetAllRovers();
                return Ok(entities);
            }catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
