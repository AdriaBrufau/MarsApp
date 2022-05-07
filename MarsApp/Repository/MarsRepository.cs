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
        public void CreateMap(MapSizeEntity x)
        {
            marscontext.Add(x);

        }

        public void CreateRover(RoverEntity rover)
        {
            marscontext.Add(rover);
        }

        public int Save()
        {
            return marscontext.SaveChanges();
        }

        public RoverEntity GetRover(int id)
        {

            return marscontext.Rovers.Where(rover =>
                rover.RoverID == id!).FirstOrDefault();
        }

        public MapSizeEntity GetMapSize(int id)
        {
            return marscontext.Maps.Where(map =>
                map.MapID == id!).FirstOrDefault();
        }
    }
}
