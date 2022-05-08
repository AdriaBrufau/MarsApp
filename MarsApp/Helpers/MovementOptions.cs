using MarsApp.Entities;

namespace MarsApp.Helpers
{
    public class MovementOptions
    {
        public CompassEnum.Orientation _orientation;
        public readonly string _order;
        MapBuilder _map;
        RoverEntity _rover;
        CalculateDirection _calculator = new CalculateDirection();

        public MovementOptions(RoverEntity rover, CompassEnum.Orientation orientation, string order, MapBuilder map)
        {   
            _rover = rover;
            _orientation = orientation;
            _order = order;
            _map = map;
        }

        

        public void MoveTo()
        {
            if (_rover == null || _rover.IsAlive == false)
            {
                return ;
            }
            else
            {
                _calculator.newPos(_rover, _order);
                _map.CheckIfRoverIs(_rover);
                
            }
        }

    }
}
