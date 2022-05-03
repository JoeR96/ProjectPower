using NUnit.Framework;
using ProjectPower.Areas.A2S_Program.Factories;
using ProjectPower.Areas.WorkoutCreation.Models;

namespace ProjectPowerTests.Tests.WorkoutManagement
{
    public class CreateWorkoutTests
    {
        [Test]
        public void HypertrophyExerciseCreates()
        {
            CreateExerciseModel model = new CreateExerciseModel
            {
                ExerciseName = "Test",
                Username = "TestUsername",
                Category = "TestCategory",
                Template = "A2SHypertrophy",
                LiftDay = 1,
                LiftOrder = 1,
                TrainingMax = 1,
                AuxillaryLift = true,
                Block = "Hypertrophy",
                AmrapRepTarget = 1,
                Intensity = 1,
                Sets = 1,
                RepsPerSet = 1,
                RoundingValue = 1,
            };
            var factory = new A2SHypertrophyFactory();
            factory.CreateExercise(model);
        }
    }
}
