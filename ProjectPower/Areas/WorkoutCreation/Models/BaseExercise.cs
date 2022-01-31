using System.ComponentModel.DataAnnotations;

namespace ProjectPower.Areas.WorkoutCreation.Models
{
    public class BaseExercise
    {
        [Required]
        public string ExerciseName { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Template { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public int ExerciseDay { get; set; }
        [Required]
        public int ExerciseOrder { get; set; }

    }
}
