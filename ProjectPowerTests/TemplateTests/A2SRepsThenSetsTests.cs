using FluentAssertions;
using NUnit.Framework;
using ProjectPower.Areas.A2S_Program.Factories;
using ProjectPowerData.Folder.Models;
using System;

namespace ProjectPowerTests.TemplateTests
{
    [TestFixture]
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

        public A2SRepsThenSetsTests()
        {
            var id = Guid.NewGuid().ToString();
            w1 = Helpers.A2SRepsThenSetsHelper.ReturnBasicRepsThenSetsExercise(id);
            w2 = Helpers.A2SRepsThenSetsHelper.ReturnBasicRepsThenSetsExercise(id);
            w3 = Helpers.A2SRepsThenSetsHelper.ReturnBasicRepsThenSetsExercise(id);
        }

        [Test]
        public void SetsIncrease()
        {
            w1.CurrentSets = 3;
            w1.CurrentReps = 8;

            factory.ProgressExercise(w1, w2);

            Assert.True(w2.GoalSets == 4);
        }
        [TestCase(3, 8, 4, 8)]
        [TestCase(4, 8, 3, 10)]
        [TestCase(4, 10, 3, 8)]

        public void RepsIncrease(int currentSets, int currentReps, int expectedSets, int expectedReps)
        {
            w2.CurrentSets = currentSets;
            w2.CurrentReps = currentReps;
            factory.ProgressExercise(w2, w3);

            w3.CurrentReps.Should().Be(expectedReps);
            w3.CurrentSets.Should().Be(expectedSets);

        }
        [Test]
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

            var nextWeek = new A2SSetsThenReps(){};

            factory.ProgressExercise(ex, nextWeek);
            nextWeek.CurrentReps.Should().Be(ex.StartingReps);
            nextWeek.CurrentSets.Should().Be(ex.StartingSets);
        }
    }
}
