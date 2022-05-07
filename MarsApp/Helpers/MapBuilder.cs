using MarsApp.Entities;

namespace MarsApp.Helpers
{
    public class MapBuilder
    {
        public readonly int Coord_X;
        public readonly int Coord_Y;

        public MapBuilder(int x, int y)
        {
            Coord_X = x; 
            Coord_Y = y;
        }

        public int[,] onCreate()
        {
            int[,] Map = new int[Coord_X, Coord_Y];
            return Map;
        }

        public void CheckIfRoverIs(RoverEntity rover)
        {
            if(
                rover.X_Position > Coord_X 
                ||rover.Y_Position > Coord_Y 
                || rover.X_Position < 0
                || rover.Y_Position < 0
            )
            {
                rover.IsAlive = false;
            }
        }
    }
}
