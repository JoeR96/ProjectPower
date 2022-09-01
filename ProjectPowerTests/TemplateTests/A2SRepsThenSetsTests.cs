using FluentAssertions;
using NUnit.Framework;
using ProjectPower.Areas.A2S_Program.Factories;
using ProjectPowerData.Folder.Models;

namespace ProjectPowerTests.TemplateTests
{
    public class A2SRepsThenSetsTests
    {
        A2SRepsThenSetsFactory factory = new A2SRepsThenSetsFactory();
        [OneTimeSetUp]
        public void ClassInit()
        {
            A2SRepsThenSetsTests factory = new A2SRepsThenSetsTests();
        }
        A2SSetsThenReps w1;
        A2SSetsThenReps w2;
        A2SSetsThenReps w3;

        List<A2SSetsThenReps> weeklyExercises = new List<A2SSetsThenReps>()
        {
            new A2SSetsThenReps(),
            new A2SSetsThenReps(),
            new A2SSetsThenReps()
          };

        public A2SRepsThenSetsTests()
        {
            var id = Guid.NewGuid().ToString();

            weeklyExercises.ForEach(x => x = Helpers.A2SRepsThenSetsHelper.CreateExercise(id));
        }

        public void SetsIncrease()
        {
            weeklyExercises[0].CurrentSets = 3;
            weeklyExercises[0].CurrentReps = 8;
            weeklyExercises[0].GoalSets = 4;
            weeklyExercises[0].GoalReps = 8;

            factory.ProgressExercise(weeklyExercises[0], weeklyExercises[1]);

            Assert.True(weeklyExercises[1].GoalSets == 4);
        }
        //[TestCase(3, 8, 4, 8)]
        //[TestCase(4, 8, 3, 10)]
        //[TestCase(4, 10, 3, 8)]

        public void RepsIncrease(int currentSets, int currentReps, int expectedSets, int expectedReps)
        {

            weeklyExercises[0].CurrentSets = currentSets;
            weeklyExercises[0].CurrentReps = currentReps;
            weeklyExercises[1].CurrentSets = currentSets;
            weeklyExercises[1].CurrentReps = currentReps;
            weeklyExercises[1].StartingReps = currentReps;
     
            factory.ProgressExercise(weeklyExercises[0], weeklyExercises[1]);

            weeklyExercises[1].CurrentReps.Should().Be(expectedReps);
            weeklyExercises[1].CurrentSets.Should().Be(expectedSets);

        }
        public void ProgressResetsAfterWeightIncrease()
        {
            var ex = new A2SSetsThenReps
            {
                StartingReps = 6,
                StartingSets = 3,
                CurrentSets = 4,
                CurrentReps = 10,
                GoalReps = 10,
                GoalSets = 4
            };

            var nextWeek = new A2SSetsThenReps() 
            { 
                StartingReps = ex.StartingReps,
                StartingSets = ex.StartingSets
            };

            factory.ProgressExercise(ex, nextWeek);
            nextWeek.CurrentReps.Should().Be(ex.StartingReps);
            nextWeek.CurrentSets.Should().Be(ex.StartingSets);
        }
    }
}
