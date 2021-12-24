using System.ComponentModel.DataAnnotations;

namespace ProjectPower.Areas.ExerciseCreation.Models
{
    public class CreateExerciseModel
    {
        [Required]
        public string ExerciseName { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Template { get; set; }
        [Required]
        public int LiftDay { get; set; }
        [Required]
        public int LiftOrder { get; set; }
        public int? StartingReps { get; set; }
        public int? StartingSets { get; set; }
        public int? RepIncreasePerSet { get; set; }
        public int? GoalSets { get; set; }
        public int? GoalReps { get; set; }
        public decimal? StartingWeight { get; set; }
        public decimal? TrainingMax { get; set; }
        public bool? AuxillaryLift { get; set; }
        public string? Block { get; set; }
        public int? AmrapRepTarget { get; set; }
        public int? Week { get; set; }
        public decimal? Intensity { get; set; }
        public int? Sets { get; set; }
        public int? RepsPerSet { get; set; }
        public decimal? RoundingValue { get; set; }
        public CreateExerciseModel(){}
    }
}
