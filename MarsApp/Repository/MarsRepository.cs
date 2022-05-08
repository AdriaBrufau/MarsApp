using MarsApp.Entities;
using MarsApp.Helpers;

namespace MarsApp.Repository
{
    public class MarsAppRepository : IMarsAppRepository
    {
        MarsAppDbContext marscontext { get; set; }

        public MarsAppRepository(
            MarsAppDbContext context
            )
        {
            marscontext = context;
        }

        //POSTs
        public void CreateRover(RoverEntity rover)
        {
            var entity = new RoverEntity
            {
                RoverID = rover.RoverID,
                Order = rover.Order,
                X_Position = rover.X_Position,
                Y_Position = rover.Y_Position,
                Compass = rover.Compass,
                IsAlive = rover.IsAlive,
                Or_Grade = rover.Or_Grade,
            };
            marscontext.Rovers.Add(entity);
            marscontext.SaveChanges();
        }

        //GETs
        public RoverEntity GetRover(int id)
        {

            return marscontext.Rovers.Where(r=>
                r.RoverID == id).FirstOrDefault();
        }

        public IEnumerable<RoverEntity> GetAllRovers()
        {
            return marscontext.Rovers.ToList();
        }

        public MapSizeEntity GetMapSize(int id)
        {
            return marscontext.Maps.Where(map =>
                map.MapID == id!).FirstOrDefault();
        }

        //PUTs

        public MapSizeEntity UpdateMap(MapSizeEntity map)
        {
            var entity = marscontext.Maps.Find(map.MapID);
            if(entity != null)
            {
                entity.X_Axis = map.X_Axis;
                entity.Y_Axis = map.Y_Axis;
                marscontext.SaveChanges();
                return entity;
            }
            return null;

        }
        public RoverEntity UpdateRaver(int MapID, int RoverID, string[] requestOrder)
        {
            var entity = marscontext.Rovers.Find(RoverID);
            var mapEntity = marscontext.Maps.Find(MapID);
            if(entity != null && mapEntity != null && requestOrder != null)
            {
                var map = new MapBuilder(mapEntity.X_Axis, mapEntity.Y_Axis);
                foreach(string order in requestOrder)
                {
                    if (entity.IsAlive) {
                        var movement = new MovementOptions(entity, entity.Compass, order, map);
                        movement.MoveTo();
                        marscontext.SaveChanges();
                    }
                    
                }
                return entity;
            }
            return null;
        }

        //DELETEs

        public void DeleteRover(RoverEntity rover)
        { 
            marscontext.Rovers.Remove(rover);
            marscontext.SaveChanges();

        }

       

    }
}
