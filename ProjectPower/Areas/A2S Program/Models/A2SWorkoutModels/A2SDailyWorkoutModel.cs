using ProjectPower.Areas.A2S_Program.Helpers;
using ProjectPowerData.Folder.Models;

namespace ProjectPower.Areas.A2S_Program.Models.A2SWorkoutModels
{
    public class A2SDailyWorkoutModel
        
    {
        public string ExerciseName { get; set; }
        public decimal WorkingWeight { get; set; }
        public int Reps { get; set; }
        public int Sets { get; set; }
        public int AmrapTarget { get; set; }
        public decimal RoundingValue { get; set; }
        public int Id { get; set; }
        public A2SDailyWorkoutModel(A2SHyperTrophy model)
        {
            ExerciseName = model.Name;
            AmrapTarget = model.AmrapRepTarget;
            Reps = model.RepsPerSet;
            Sets = (int)model.Sets;
            WorkingWeight = model.WorkingWeight();
            Id = (int)model.Id;
        }
    }
}
