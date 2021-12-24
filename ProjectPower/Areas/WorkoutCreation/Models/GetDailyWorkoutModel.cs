using System;
using System.ComponentModel.DataAnnotations;


namespace ProjectPower.Areas.WorkoutCreation.Models
{
    public class GetDailyWorkoutModel
    {
        [Required]
        public string Username { get; set; }
        public int ExerciseDay { get;set; }
        public int ExerciseWeek { get; set; }
    }
}
