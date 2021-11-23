

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

    }
}
