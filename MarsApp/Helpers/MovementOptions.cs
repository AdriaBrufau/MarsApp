using MarsApp.Entities;

namespace MarsApp.Helpers
{
    public class MovementOptions
    {
        public CompassEnum.Orientation _orientation;
        public readonly string _order;
        MapBuilder _map;
        int _x_position;
        int _y_position;
        CalculateDirection _calculator = new CalculateDirection();

        public MovementOptions(CompassEnum.Orientation orientation, string order, MapBuilder map)
        {
            _orientation = orientation;
            _order = order;
            _map = map;
        }

        public void ChangeOrientation(RoverEntity rover)
        {
            switch (_order)
            {
                //case "L":
                //    _orientation = _orientation - 90;
                //    rover.Orientation = _orientation;
                //    rover.Order = _order;
                //    break;
                //case "R":
                //    _orientation = _orientation + 90;
                //    rover.Orientation = _orientation;
                //    rover.Order = _order;
                //    break;
                //case "F":
                //    _x_position = _x_position + 1;
                //    _y_position = _y_position + 1;
                //    rover.Orientation = _orientation;
                //    rover.Order = _order;
                //    break;
                //default:
                //    break;
            }

        }

        public void MoveTo(RoverEntity rover)
        {
            if (rover == null || rover.IsAlive == false)
            {
                return;
            }
            else
            {
                _calculator.newPos(rover, _order);
                _map.CheckIfRoverIs(rover);
                
            }
        }

    }
}
