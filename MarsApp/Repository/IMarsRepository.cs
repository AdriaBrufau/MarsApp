using MarsApp.Entities;

namespace MarsApp.Repository
{
    public interface IMarsAppRepository
    {
        void CreateRover(RoverEntity rover);
        RoverEntity GetRover(int id);
        MapSizeEntity GetMapSize(int id);
        IEnumerable<RoverEntity> GetAllRovers();

        MapSizeEntity UpdateMap(MapSizeEntity map);
        RoverEntity UpdateRaver(int RoverID, int MapID, string[] requestOrder);
        void DeleteRover(RoverEntity rover);
    }
}