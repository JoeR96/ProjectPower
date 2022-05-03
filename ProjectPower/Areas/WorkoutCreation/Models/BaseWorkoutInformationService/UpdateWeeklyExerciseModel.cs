namespace ProjectPower.Areas.WorkoutCreation.Models.BaseWorkoutInformationService
{
    public class UpdateWeeklyExerciseModel
    {
        public string ExerciseMasterId { get; set; }
        public int Reps { get; set; }
        public int? Sets { get; set; }
        public int Week { get; set; }
    }
}
