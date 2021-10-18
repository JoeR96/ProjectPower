using ProjectPowerData.Folder.Models;

namespace ProjectPower.Areas.A2S_Program.Models.A2SWorkoutModels
{
    public class UpdateA2SAmrapResultModel
    {
        public int? AmrapRepResult { get; set; }
        public string ExerciseName { get; set; }
        public string UserName { get; set; }


        public UpdateA2SAmrapResultModel(A2SHyperTrophyModel dbEntity)
        {
            AmrapRepResult = dbEntity.AmrapRepResult;
        }
    }
}
