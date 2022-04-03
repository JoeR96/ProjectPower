using ProjectPowerData.Folder.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace ProjectPower.Areas.WorkoutCreation.Models
{
    public class GetDailyWorkoutModel
    {
        [Required]
        public string Username { get; set; }
        public int ExerciseDay { get; set; }
        public int ExerciseWeek { get; set; }
    }

    public class GetDailyWorkoutView
    {
        List<ProjectPowerData.Folder.Models.Exercise> ExerciseCollection { get; set; }
    }

}