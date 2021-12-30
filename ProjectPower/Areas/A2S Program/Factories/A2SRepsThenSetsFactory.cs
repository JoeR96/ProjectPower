using ProjectPower.Areas.A2S_Program.Models.A2SWorkoutModels;
using ProjectPower.Areas.ExerciseCreation.Models;
using ProjectPower.FactoryPattern;
using ProjectPowerData.Folder.Models;

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

                dbEntity.RepIncreasePerSet = (int)model.RepIncreasePerSet;
                dbEntity.GoalReps = (int)model.GoalReps;
                dbEntity.GoalSets = (int)model.GoalSets;
                dbEntity.StartingSets = (int)model.StartingSets;
                dbEntity.StartingReps = (int)model.StartingReps;
                dbEntity.StartingWeight = (int)model.StartingWeight;
                dbEntity.Week = i + 1;
            }
        }
    }
}
