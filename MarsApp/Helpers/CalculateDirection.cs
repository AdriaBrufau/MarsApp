using MarsApp.Entities;

namespace MarsApp.Helpers
{
    public class CalculateDirection
    {
        public Dictionary<int, CompassEnum.Orientation> calc = new Dictionary<int, CompassEnum.Orientation>()
        {
            { 0, CompassEnum.Orientation.North },
            { 90, CompassEnum.Orientation.East },
            { 180, CompassEnum.Orientation.South },
            { 270, CompassEnum.Orientation.West }  
        };


        public void newPos(RoverEntity rover, string or)
        {
            rover.Order = or;
            switch (or)
            {
                case "L":
                    rover.Or_Grade = rover.Or_Grade - 90;
                    if (rover.Or_Grade < 0)
                    {
                        rover.Or_Grade = 270;
                    }
                    break;
                case "R":
                    rover.Or_Grade = rover.Or_Grade + 90;
                    if (rover.Or_Grade > 270)
                    {
                        rover.Or_Grade = 0;
                    }
                    break;
                case "F":
                    switch (rover.Or_Grade)
                    {
                        case 0:
                        case 180:
                            rover.Y_Position++;
                            break;
                        case 90:
                        case 270:
                            rover.X_Position++;
                            break;
                    }
                    break;
                default:
                    break;
            }
            rover.Compass = calc[rover.Or_Grade];
            
        }

    }
}
