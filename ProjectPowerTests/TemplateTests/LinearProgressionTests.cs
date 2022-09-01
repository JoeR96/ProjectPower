using FluentAssertions;
using NUnit.Framework;
using ProjectPower.Areas.LinearProgression;
using ProjectPower.Areas.LinearProgression.Models;
using ProjectPower.Areas.LinearProgression.Services;

namespace ProjectPowerTests.TemplateTests
{
    [TestFixture]
    public class LinearProgressionTests
    {
        //accessory
        //x to y reps
        //12 reps good form = increase weight
        //x to y sets

        //accessory superset 
        //x to y reps
        //12 reps good form = increase weight
        //x to y sets


        //primary
        //set start weight 
        //if you dont know start weight trigger the first time that exercise is opened to do sets of 5 till tough and - 10%
        //set rounding value with a default value
        //set reps and sets with default values
        //2x5 and 1x5+ amrap default for primary
        //option for just amrap 

        [TestCase]
        public void AccessoryWeightIncreasesWhenSetsByRepsCompleted()
        {
            var exercise = new LinearProgressionExercise
            {
                TargetSets = 3,
                MaximumReps = 12,
                MinimumReps = 8,
                WeightIndex = 0
            };

            var finishedWorkout = new LinearProgressionWorkout
            {
                setsAndReps = new List<int>()
                {
                    12,
                    12,
                    12
                }
            };

            var service = new LinearProgressionService();
            service.ProgressAccessoryExercise(exercise,finishedWorkout);

            exercise.WeightIndex.Should().Be(1);

        }

        [TestCase]
        public void AccessoryWeightDecreasesWhenSetsByRepsFailed()
        {
            var exercise = new LinearProgressionExercise
            {
                TargetSets = 3,
                MaximumReps = 12,
                MinimumReps = 8,
                WeightIndex = 1
            };

            var finishedWorkout = new LinearProgressionWorkout
            {
                setsAndReps = new List<int>()
                {
                    12,
                    12,
                    7
                }
            };

            var service = new LinearProgressionService();
            service.ProgressAccessoryExercise(exercise, finishedWorkout);

            exercise.WeightIndex.Should().Be(0);

        }

        [TestCase]
        public void PrimaryWeightIncreasesWhenCompleted()
        {
            var exercise = new LinearProgressionExercise
            {
                TargetSets = 3,
                PrimaryExercise = true,
                MinimumReps = 5,
                WeightProgression = 2.5m,
                WorkingWeight = 100m
            };

            var finishedWorkout = new LinearProgressionWorkout
            {
                setsAndReps = new List<int>()
                {
                    5,
                    5,
                    7
                }
            };

            var service = new LinearProgressionService();
            service.ProgressPrimaryExercise(exercise, finishedWorkout);

            exercise.WorkingWeight.Should().Be(102.5m);
        }


        [TestCase]
        public void PrimaryWeightDecreasesToNinetyPercentWhenFailed()
        {
            var exercise = new LinearProgressionExercise
            {
                TargetSets = 3,
                PrimaryExercise = true,
                MinimumReps = 5,
                WeightProgression = 2.5m,
                WorkingWeight = 100m,
                AttemptsBeforeDeload = 3,
                CurrentAttempt = 3
            };

            var finishedWorkout = new LinearProgressionWorkout
            {
                setsAndReps = new List<int>()
                {
                    2,
                    2,
                    2
                }
            };

            var service = new LinearProgressionService();
            service.ProgressPrimaryExercise(exercise, finishedWorkout);

            exercise.WorkingWeight.Should().Be(90m);
        }
    }
}
