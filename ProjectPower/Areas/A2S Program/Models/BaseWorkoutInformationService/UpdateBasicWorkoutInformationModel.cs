using ProjectPowerData.Folder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPower.Areas.A2S_Program.Models.BaseWorkoutInformationService
{
    public class UpdateBasicWorkoutInformationModel
    {
        public string Name { get; set; }
        public string Category { get; set; }

        public UpdateBasicWorkoutInformationModel(BasicWorkoutInformation dbEntity)
        {
            Name = dbEntity.Name;
            Category = dbEntity.Category;
        }
    }
}
