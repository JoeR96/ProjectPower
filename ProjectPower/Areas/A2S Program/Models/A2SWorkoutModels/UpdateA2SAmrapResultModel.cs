using ProjectPowerData.Folder.Models;
using System.ComponentModel.DataAnnotations;

namespace ProjectPower.Areas.A2S_Program.Models.A2SWorkoutModels
{
    public class UpdateA2SAmrapResultModel
    {
        [Required]
        public int? AmrapRepResult { get; set; }

        public UpdateA2SAmrapResultModel(A2SHyperTrophy dbEntity)
        {
            dbEntity.AmrapRepResult = AmrapRepResult;
        }
    }
}
