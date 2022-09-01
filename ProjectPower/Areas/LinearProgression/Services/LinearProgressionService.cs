using ProjectPower.Areas.LinearProgression.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPower.Areas.LinearProgression.Services
{
    internal class LinearProgressionService
    {
        internal void ProgressAccessoryExercise(Models.LinearProgressionExercise exercise, Models.LinearProgressionWorkout finishedWorkout)
        {
            int completedSets = 0;

            finishedWorkout.setsAndReps.ForEach(x =>
            {
                if (Enumerable.Range(exercise.MinimumReps, exercise.MaximumReps).Contains(x))
                {
                    completedSets++;
                };
            });

            if(completedSets == exercise.TargetSets)
            {
                IncreaseAccessoryWeight(exercise);
            }
            else
            {
                DecreaseAccessoryWeight(exercise);
            }
        }


        private void IncreaseAccessoryWeight(Models.LinearProgressionExercise exercise) => exercise.WeightIndex++;

        private void DecreaseAccessoryWeight(Models.LinearProgressionExercise exercise) => exercise.WeightIndex--;

        private void RoundToNearestIncrement(decimal workingWeight, decimal roundingValue) => Math.Round(workingWeight / roundingValue);

        internal void ProgressPrimaryExercise(LinearProgressionExercise exercise, LinearProgressionWorkout finishedWorkout)
        {
            if(finishedWorkout.setsAndReps.Count == exercise.TargetSets &&
                !finishedWorkout.setsAndReps.Any(x => x < exercise.MinimumReps))
            {
                exercise.WorkingWeight += exercise.WeightProgression;
            }
            else
            {
                if(exercise.CurrentAttempt < exercise.AttemptsBeforeDeload)
                {
                    exercise.CurrentAttempt++;
                }
                else
                {
                    DecreasePrimaryWeight(exercise);
                }
            }
        }

        private void DecreasePrimaryWeight(LinearProgressionExercise exercise)
        {
            exercise.CurrentAttempt = 0;
            exercise.WorkingWeight = (exercise.WorkingWeight / 100) * 90;
        }
    }
}
