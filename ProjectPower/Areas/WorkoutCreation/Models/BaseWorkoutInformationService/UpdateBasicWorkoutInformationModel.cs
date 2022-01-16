using ProjectPowerData.Folder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPower.Areas.WorkoutCreation.Models.BaseWorkoutInformationService
{
    public class UpdateBasicWorkoutInformationModel
    {
        public int Id { get; set; }
        public int Reps { get; set; }
        public int? Sets {get;set;}
    }
}
