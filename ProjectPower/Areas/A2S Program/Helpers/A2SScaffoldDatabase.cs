using ProjectPower.Areas.A2S_Program.Models.A2SWorkoutModels;
using ProjectPower.Areas.UserAccounts.Services;
using ProjectPower.Areas.UserAccounts.Services.Interfaces;
using ProjectPowerData;
using ProjectPowerData.Folder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPower.Areas.A2S_Program.Helpers
{
    public class A2SScaffoldDatabase
    {
        private readonly DataContext _dc;
  
        public A2SScaffoldDatabase(DataContext context)
        {
            _dc = context;
        }

        public void PopulateA2SWorkout(CreateA2SWorkoutModel model)
        {
            Dictionary<string, A2SLift> fullWorkout = new Dictionary<string, A2SLift>();
            A2SHelper helper = new A2SHelper();
            
            if(model.AuxillaryLift)
            {
                fullWorkout = helper.A2SAuxLifts;
            }
            else
            {
                fullWorkout = helper.A2SPrimaryLifts;
            }
            var x = helper.A2SAuxLifts;

            int week = 0;
            for (int i = 0; i < 3; i++)
            {
                var currentBlock = fullWorkout.ElementAt(i);
                                
                for (int j = 0; j < 6; j++)
                {
                    Guid g = Guid.NewGuid();
                    var weeklyValues = currentBlock.Value;                   
                    var dbEntity = new A2SHyperTrophyModel();
                    week++;

                    dbEntity.Name = model.Name;
                    dbEntity.TrainingMax = model.TrainingMax;
                    dbEntity.AuxillaryLift = model.AuxillaryLift;
                    dbEntity.Block = currentBlock.Key;
                    dbEntity.AmrapRepTarget = weeklyValues.amrapRepTarget[j];
                    dbEntity.AmrapRepResult = 0;
                    dbEntity.Week = week;
                    dbEntity.Intensity = weeklyValues.intensity[j];
                    dbEntity.Sets = weeklyValues.sets;
                    dbEntity.RepsPerSet = weeklyValues.repsPerSet[j];
                    dbEntity.UniqueId = g.ToString();
                    dbEntity.Username = model.Username;
                    _dc.A2SWorkoutExercises.Add(dbEntity);
                }
            }
            
            _dc.SaveChanges();
        }
    }
}
