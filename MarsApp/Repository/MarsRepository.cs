using MarsApp.Entities;

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


    }
}
