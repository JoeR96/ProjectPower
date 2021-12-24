using ProjectPowerData.Folder.Models;


namespace ProjectPower.Areas.WorkoutCreation.Models
{
    public class Exercise
    {
        public BasicWorkoutInformation BasicWorkoutInformation { get; set; }
        public A2SHyperTrophy A2SHyperTrophy { get; set; }
        public A2SRepsThenSets A2SRepsThenSets { get; set; }
    }
}
