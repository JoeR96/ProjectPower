using ProjectPower.Areas.ExerciseCreation.Models;
using System.ComponentModel.DataAnnotations;

namespace ProjectPower.Areas.A2S_Program.Models.A2SWorkoutModels
{
    public class CreateA2SRepsThenSetsModel : CreateExerciseModel
    {
        [Required]
        public int StartingReps { get; set; }
        [Required]
        public int StartingSets { get; set; }
        [Required]
        public int RepIncreasePerSet { get; set; }
        [Required]
        public int GoalSets { get; set; }
        [Required]
        public int GoalReps { get; set; }
        [Required]
        public decimal StartingWeight { get; set; }
    }
}
