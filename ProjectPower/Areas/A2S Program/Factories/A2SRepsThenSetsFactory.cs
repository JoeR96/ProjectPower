using ProjectPower.Areas.A2S_Program.Helpers;
using ProjectPower.Areas.ExerciseCreation.Models;
using ProjectPower.Areas.WorkoutCreation.Models.BaseWorkoutInformationService;
using ProjectPower.FactoryPattern;
using ProjectPowerData.Folder.Models;
using System;
using System.Linq;

namespace ProjectPower.Areas.A2S_Program.Factories
{
    public class A2SRepsThenSetsFactory : ExerciseFactory
    {
        public override void CreateExercise(CreateExerciseModel model)
        {
            const int workoutTotalDuration = 20;
            var masterId = Guid.NewGuid();

            for (int i = 0; i < workoutTotalDuration; i++)
            {
                var dbEntity = new A2SSetsThenReps();
                CreateBaseExercise(model, dbEntity);
                dbEntity.ExerciseMasterId = masterId.ToString();
                dbEntity.RepIncreasePerSet = (int)model.RepIncreasePerSet;
                dbEntity.GoalReps = (int)model.GoalReps;
                dbEntity.GoalSets = (int)model.GoalSets;
                dbEntity.StartingSets = (int)model.StartingSets;
                dbEntity.StartingReps = (int)model.StartingReps;
                dbEntity.StartingWeight = (int)model.StartingWeight;
                dbEntity.Week = i + 1;
                _dc.BasicWorkoutInformation.Add(dbEntity);
                _dc.SaveChanges();
            }
        }

        internal override void UpdateExercise(UpdateBasicWorkoutInformationModel model, BasicWorkoutInformation exercise)
        {
            var setsThenReps = (A2SSetsThenReps)exercise;
            var nextWeek = (A2SSetsThenReps)_dc.BasicWorkoutInformation.Where(e => e.ExerciseMasterId == exercise.ExerciseMasterId && e.Week == setsThenReps.Week + 1).FirstOrDefault();

            A2SHelper.ProgressSetsThenReps(model, setsThenReps, nextWeek);
            setsThenReps.ExerciseCompleted = true;
            _dc.BasicWorkoutInformation.Update(nextWeek);
            _dc.BasicWorkoutInformation.Update(setsThenReps);
            _dc.SaveChanges();
        }


    }
}
