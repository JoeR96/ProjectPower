using System;
using System.Collections.Generic;
using System.Linq;
using ProjectPower.Areas.A2S_Program.Factories;
using ProjectPower.Areas.A2S_Program.Models.A2SWorkoutModels;
using ProjectPower.Areas.ExerciseCreation.Models;
using ProjectPower.Areas.WorkoutCreation.Models;
using ProjectPower.FactoryPattern;
using ProjectPowerData;
using ProjectPowerData.Folder.Models;

namespace ProjectPower.Areas.WorkoutCreation.Services
{
    public class WorkoutManagementService : IWorkoutManagementService
    {
        Dictionary<string, ExerciseFactory> exerciseFactories = null;
        public WorkoutManagementService()
        {
            A2SHypertrophyFactory a2SHypertrophyFactory = new A2SHypertrophyFactory();
            A2SRepsThenSetsFactory a2SRepsThenSetsFactory = new A2SRepsThenSetsFactory();

            exerciseFactories = new Dictionary<string, ExerciseFactory>
            {
                { "A2SHypertrophy", a2SHypertrophyFactory },
                { "A2SRepsThenSets", a2SRepsThenSetsFactory }
            };
        }

        public void CreateWorkout(CreateWorkoutMasterTemplateModel model)
        {
            model.ExerciseDaysAndOrders.ForEach(e => exerciseFactories[e.Template].CreateExercise(e));
        }

        public IQueryable<BasicWorkoutInformation> GetDailyWorkout(string username, int week, int day)
        {
            DataContext dc = new DataContext();
            List<BasicWorkoutInformation> bwiList = new List<BasicWorkoutInformation>();

            var dbEntities = dc.BasicWorkoutInformation.Where(e => e.UserName == username);
           
            foreach(var bwi in dbEntities)
            {

                if(bwi.Template == "A2SHypertrophy")
                {
                    A2SHyperTrophy exercise = (A2SHyperTrophy)dc.A2SWorkoutExercises.Where(e => e.UniqueId == bwi.UniqueId && 
                    e.Week == week);
                    bwiList.Add(exercise);

                }
                if (bwi.Template == "A2SRepsThenSets")
                {
                    A2SRepsThenSets exercise = (A2SRepsThenSets)dc.A2SWorkoutTemplate.Where(e => e.UniqueId == bwi.UniqueId &&
                    e.Week == week);
                    bwiList.Add(exercise);

                }
            }

            return (IQueryable<BasicWorkoutInformation>)bwiList;
        }

       
    }
}
