using ProjectPowerData.Folder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPower.Areas.WorkoutCreation.Models.BaseWorkoutInformationService
{
    public class ShowBasicWorkoutInformationModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        
        public ShowBasicWorkoutInformationModel(BasicWorkoutInformation dbEntity)
        {
            Name = dbEntity.Name;
            Category = dbEntity.Category;
        }
    }
}
