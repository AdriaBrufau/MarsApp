using MarsApp.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MarsApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MapController : ControllerBase
    {
        private readonly MarsAppDbContext _marsmap;

        public MapController(
            MarsAppDbContext methods)
        {
            _marsmap = methods;
        }

        [HttpGet]
        public ActionResult GetMapData(int id)
        {
            try
            {

                var entity = _marsmap.Find<MapSizeEntity>(id);
                return Ok(entity);
            }catch(Exception ex)
            {
                return BadRequest(ex);
            }


        }
        [HttpPut]
        public ActionResult UpdateMap(int id, int x, int y)
        {
            try
            {
                var entity = _marsmap.Find<MapSizeEntity>(id);
                if(entity == null)
                {
                    return NotFound();
                }
                entity.X_Axis = x;
                entity.Y_Axis = y;
                _marsmap.SaveChanges();
                return Ok(entity);
            }catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
