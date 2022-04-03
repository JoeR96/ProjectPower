using ProjectPowerData.Folder.Models;


namespace ProjectPower.Areas.WorkoutCreation.Models
{
    public class Exercise
    {
        public ProjectPowerData.Folder.Models.Exercise BasicWorkoutInformation { get; set; }
        public A2SHyperTrophy A2SHyperTrophy { get; set; }
        public A2SSetsThenReps A2SRepsThenSets { get; set; }
    }
}
