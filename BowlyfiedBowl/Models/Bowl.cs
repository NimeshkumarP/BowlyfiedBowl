using System.ComponentModel.DataAnnotations;

namespace BolyfiedBowl.Models  // ✅ Use your real project name!
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
