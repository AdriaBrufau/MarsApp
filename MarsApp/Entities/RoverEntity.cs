namespace MarsApp.Entities
{
    public class RoverEntity
    {
        public int RoverID { get; set; }
        public int X_Position { get; set; }
        public int Y_Position { get; set; }
        public string? Order { get; set; }
        public int Or_Grade { get; set; }
        public CompassEnum.Orientation Compass { get; set; }
        public bool IsAlive { get; set; }

    }
}
