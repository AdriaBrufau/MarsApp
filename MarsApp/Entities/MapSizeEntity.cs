using System.ComponentModel.DataAnnotations;

namespace MarsApp.Entities
{
    public class MapSizeEntity
    {
        [Key]
        public int MapID { get; set; }
        [Required]
        public int X_Axis { get; set; }
        [Required]
        public int Y_Axis { get; set; }
    }
}
