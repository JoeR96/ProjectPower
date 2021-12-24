using ProjectPower.Areas.ExerciseCreation.Models;
using System.ComponentModel.DataAnnotations;

namespace ProjectPower.Areas.A2S_Program.Models.A2SWorkoutModels
{
    public class CreateA2SHypertrophyModel : CreateExerciseModel
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
        public int Week { get; set; }
        [Required]
        public decimal Intensity { get; set; }
        [Required]
        public int Sets { get; set; }
        [Required]
        public int RepsPerSet { get; set; }
        [Required]
        public decimal RoundingValue { get; set; }

    }
}
