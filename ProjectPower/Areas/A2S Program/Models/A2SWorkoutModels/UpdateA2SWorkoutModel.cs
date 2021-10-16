using ProjectPowerData.Folder.Models;

namespace ProjectPower.Areas.A2S_Program.Models.A2SWorkoutModels
{
    public class UpdateA2SWorkoutModel
    {
        public int? AmrapRepResult { get; set; }

        public UpdateA2SWorkoutModel(A2SHyperTrophyModel dbEntity)
        {
            AmrapRepResult = dbEntity.AmrapRepResult;
        }
    }
}
