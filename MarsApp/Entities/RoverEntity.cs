using System.ComponentModel.DataAnnotations;

namespace MarsApp.Entities
{
    public class RoverEntity
    {
        [Key]
        [Required]
        public int RoverID { get; set; }
        [Required]
        public int X_Position { get; set; }
        [Required]
        public int Y_Position { get; set; }
        public string? Order { get; set; }
        public int Or_Grade { get; set; }
        public CompassEnum.Orientation Compass { get; set; }
        [Required]
        public bool IsAlive { get; set; }

    }
}
