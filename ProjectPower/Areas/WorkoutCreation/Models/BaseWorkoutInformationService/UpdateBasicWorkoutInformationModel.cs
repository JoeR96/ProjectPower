namespace ProjectPower.Areas.WorkoutCreation.Models.BaseWorkoutInformationService
{
    public class UpdateBasicWorkoutInformationModel
    {
        public string Id { get; set; }
        public int Reps { get; set; }
        public int? Sets { get; set; }
        public int Week { get; set; }
    }
}
