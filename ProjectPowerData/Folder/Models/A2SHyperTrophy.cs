using System.ComponentModel.DataAnnotations;

namespace ProjectPowerData.Folder.Models
{
    public class A2SHyperTrophy : BasicWorkoutInformation
    {
        [Required]
        public decimal TrainingMax { get; set; }
        [Required]
        public bool AuxillaryLift { get; set; }
        [Required]
        public string Block { get; set; }
        [Required]
        public int AmrapRepTarget { get; set; }
        [Required]
        public int? AmrapRepResult { get; set; }

        [Required]
        public decimal Intensity { get; set; }
        [Required]
        public int Sets { get; set; }
        [Required]
        public int RepsPerSet { get; set; }
        [Required]
        public decimal RoundingValue { get; set; }
        public A2SHyperTrophy() { }
    }
}
