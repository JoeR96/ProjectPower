using ProjectPower.Areas.A2S_Program.Models.A2SWorkoutModels;
using ProjectPower.Areas.ExerciseCreation.Models;
using ProjectPower.Areas.WorkoutCreation.Models.BaseWorkoutInformationService;
using ProjectPower.FactoryPattern;
using ProjectPowerData.Folder.Models;
using System.Linq;

namespace ProjectPower.Areas.A2S_Program.Factories
{
    public class A2SRepsThenSetsFactory : ExerciseFactory
    {
        public override void CreateExercise(CreateExerciseModel model)
        {
            const int workoutTotalDuration = 20;

            for (int i = 0; i < workoutTotalDuration; i++)
            {
                var dbEntity = new A2SRepsThenSets();
                CreateBaseExercise(model, dbEntity);

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
            var castedType = (A2SRepsThenSets)exercise;

            if (model.Reps >= castedType.GoalReps && model.Sets >= castedType.GoalSets)
            {
                castedType.ExerciseTargetCompleted = true;
                BasicWorkoutInformation nextWeek = _dc.BasicWorkoutInformation.Where(e => e.Id == castedType.Id + 1).FirstOrDefault();
                var castedNextWeek = (A2SRepsThenSets)nextWeek;

                if(castedType.StartingSets < castedNextWeek.GoalSets)
                {
                    castedNextWeek.StartingSets = castedNextWeek.StartingSets++;
                }
                if (castedType.StartingSets == castedNextWeek.GoalSets)
                {
                    castedNextWeek.StartingSets = castedNextWeek.StartingSets;
                }

            }
            else
            {
                castedType.ExerciseTargetCompleted = false;
            }
            castedType.ExerciseCompleted = true;

            _dc.BasicWorkoutInformation.Update(castedType);
            _dc.SaveChanges();
        }
    }
}
