using ProjectPower.Areas.A2S_Program.Helpers;
using ProjectPower.Areas.A2S_Program.Models.A2SWorkoutModels;
using ProjectPower.Areas.A2S_Program.Service.Interfaces;
using ProjectPower.Areas.UserAccounts.Services.Interfaces;
using ProjectPower.Areas.WorkoutCreation.Models;
using ProjectPowerData;
using ProjectPowerData.Folder.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectPower.Areas.A2S_Program.Service
{
    public class A2SWorkoutService : IA2SWorkoutService
    {
        private readonly DataContext _dc;

        private A2SHypertrophyTemplateValues _a2sHelper = new A2SHypertrophyTemplateValues();
        public A2SWorkoutService(DataContext context)
        {
            _dc = context;
        }

        public void Delete(long id)
        {
            _dc.SaveChanges();
        }

        internal static void UpdateTrainingMax(decimal trainingMax, int updateModifier)
        {
            switch (updateModifier)
            {
                case -2: return;
                case -1: return;
                case 0: return;
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         
                case 4: return;
                case 5: return;
            }
        }
    }
}
