using MarsApp.Entities;

namespace MarsApp.Repository
{
    public interface IMarsAppRepository
    {
        void CreateRover(RoverEntity rover);
        void CreateMap(MapSizeEntity x);
        RoverEntity GetRover(int id);
        MapSizeEntity GetMapSize(int id);
        int Save();

    }
}