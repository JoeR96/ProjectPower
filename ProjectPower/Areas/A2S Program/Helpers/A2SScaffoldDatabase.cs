using ProjectPower.Areas.A2S_Program.Models.A2SWorkoutModels;
using ProjectPowerData;
using ProjectPowerData.Folder.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjectPower.Areas.A2S_Program.Helpers
{
    public class A2SScaffoldDatabase
    {
        private readonly DataContext _dc;

        public A2SScaffoldDatabase(DataContext context)
        {
            _dc = context;
        }

        public void PopulateA2SWorkout(CreateA2SHypertrophyModel model)
        {
            Dictionary<string, A2SLift> fullWorkout = new Dictionary<string, A2SLift>();
            A2SHypertrophyTemplateValues helper = new A2SHypertrophyTemplateValues();
            fullWorkout = model.AuxillaryLift == true ? helper.A2SAuxLifts : helper.A2SPrimaryLifts;
            int week = 0;
            for (int i = 0; i < 3; i++)
            {
                var currentBlock = fullWorkout.ElementAt(i);

                for (int j = 0; j < 6; j++)
                {

                    var weeklyValues = currentBlock.Value;
                    var dbEntity = new A2SHyperTrophy();
                    week++;

                    dbEntity.TrainingMax = model.TrainingMax;
                    dbEntity.AuxillaryLift = model.AuxillaryLift;
                    dbEntity.Block = currentBlock.Key;
                    dbEntity.AmrapRepTarget = weeklyValues.amrapRepTarget[j];
                    dbEntity.AmrapRepResult = 0;
                    dbEntity.Week = week;
                    dbEntity.Intensity = weeklyValues.intensity[j];
                    dbEntity.Sets = weeklyValues.sets;
                    dbEntity.RepsPerSet = weeklyValues.repsPerSet[j];
                    _dc.BasicWorkoutInformation.Add(dbEntity);
                }
            }

            _dc.SaveChanges();
        }
    }
}
