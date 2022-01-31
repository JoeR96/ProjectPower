using ProjectPower.Areas.WorkoutCreation.Models.BaseWorkoutInformationService;
using ProjectPowerData.Folder.Models;
using System;

namespace ProjectPower.Areas.A2S_Program.Helpers
{
    public static class A2SHelper
    {
        public static decimal WorkingWeight(A2SHyperTrophy model)
        {
            var workingWeight = model.Intensity * model.TrainingMax;
            var newWeight = Math.Ceiling(workingWeight / model.RoundingValue);
            var newNumber = newWeight * model.RoundingValue;
            return newNumber;
        }

        public static decimal UpdateTrainingMax(decimal trainingMax, int updateModifier)
        {
            decimal modifier = 0;
            switch (updateModifier)
            {
                case -2: modifier = -2m; break;
                case -1: modifier = -1m; break;
                case 0: modifier = 0m; break;
                case 1: modifier = 0.5m; break;
                case 2: modifier = 1m; break;
                case 3: modifier = 1.5m; break;
                case 4: modifier = 2m; break;
                case 5: modifier = 3m; break;
                default: modifier = 0m; break;
            }

            return trainingMax / 100 * (100 + modifier);
        }

        public static void ProgressSetsThenReps(UpdateBasicWorkoutInformationModel model, A2SSetsThenReps setsThenReps, A2SSetsThenReps nextWeek)
        {
            if (model.Reps >= setsThenReps.CurrentReps && model.Sets == setsThenReps.GoalSets)
            {
                nextWeek.CurrentReps = setsThenReps.StartingReps += setsThenReps.RepIncreasePerSet;
                nextWeek.CurrentSets = setsThenReps.StartingSets;
            }
            else if (model.Reps >= setsThenReps.CurrentReps && model.Sets < setsThenReps.GoalSets)
            {
                nextWeek.CurrentSets += 1;
            }
            else
            {
                setsThenReps.ExerciseTargetCompleted = false;
            }
        }

        public static void ProgressA2SHypertrophy(A2SHyperTrophy hypertrophyExercise, A2SHyperTrophy nextWeek)
        {
            if (hypertrophyExercise.AmrapRepResult >= hypertrophyExercise.AmrapRepTarget)
            {
                int updateModifier = (int)(hypertrophyExercise.AmrapRepResult - hypertrophyExercise.AmrapRepTarget);
                hypertrophyExercise.ExerciseTargetCompleted = true;
                Math.Clamp(updateModifier, -2, 5);
                nextWeek.TrainingMax = A2SHelper.UpdateTrainingMax(hypertrophyExercise.TrainingMax, updateModifier);
            }
            else
            {
                hypertrophyExercise.ExerciseTargetCompleted = false;
            }
        }
    }
}
