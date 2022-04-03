using ProjectPowerData.Folder.Models;

namespace ProjectPower.Areas.WorkoutCreation.Models.BaseWorkoutInformationService
{
    public class ShowBasicWorkoutInformationModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }

        public ShowBasicWorkoutInformationModel(ProjectPowerData.Folder.Models.Exercise dbEntity)
        {
            Name = dbEntity.Name;
            Category = dbEntity.Category;
        }
    }
}
