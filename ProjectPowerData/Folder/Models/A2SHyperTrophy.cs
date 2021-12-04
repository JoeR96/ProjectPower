using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectPowerData.Folder.Models
{
    public class A2SHyperTrophy
    { 
        [Required]
        public decimal TrainingMax { get; set; }
        [Required]
        public bool AuxillaryLift { get; set; }
        [Required]
<<<<<<< HEAD
        public string Template { get; set; }
        [Required]
        public string Block { get; set; } 
=======
        public string Block { get; set; }
>>>>>>> f69e85f (123)
        [Required]
        public int AmrapRepTarget { get; set; }
        [Required]
        public int? AmrapRepResult { get; set; }
        [Required]
        public int Week { get; set; }
        [Required]
        public decimal Intensity { get; set; }
        [Required]
        public int Sets { get; set; }
        [Required]
        public int RepsPerSet { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string UniqueId { get; set; }
        [Required]
        public decimal RoundingValue { get; set; }
    }
}
