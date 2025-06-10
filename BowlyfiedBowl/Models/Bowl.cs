using System.ComponentModel.DataAnnotations;

namespace BowlyfiedBowl.Models
{
    public class Bowl
    {
        public int Id { get; set; }

        [Required]
        public string? Material { get; set; }

        public string? Capacity { get; set; }

        public string? Dimensions { get; set; }

        public string? Weight { get; set; }

        public string? ColorOptions { get; set; }

        public bool MicrowaveSafe { get; set; }

        public bool DishwasherSafe { get; set; }

        public string? MadeIn { get; set; }
    }
}
