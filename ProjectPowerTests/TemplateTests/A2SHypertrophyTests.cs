using FluentAssertions;
using NUnit.Framework;
using ProjectPower.Areas.A2S_Program.Factories;
using ProjectPowerData.Folder.Models;

namespace ProjectPowerTests.TemplateTests
{
    [TestFixture]
    public class A2SHypertrophyTests
    {
        A2SHypertrophyFactory factory;
        [OneTimeSetUp]
        public void ClassInt()
        {
            factory = new A2SHypertrophyFactory();
        }

        [Test]
        public void A2SHypertrophyWorkingWeightCalculates()
        {

            A2SHyperTrophy e = new A2SHyperTrophy
            {
                TrainingMax = 100m,
                Intensity = 0.7m,
                RoundingValue = 2.5m
            };

            factory.SetWorkingWeight(e);
            e.WorkingWeight.Should().Be(70m);
            Assert.AreEqual(70m, e.WorkingWeight);
        }
        [TestCase(101, 1.25, 101.25)]
        [TestCase(100.5, 1.25, 100)]
        [TestCase(101, 2.5, 100)]
        [TestCase(101.5, 2.5, 102.5)]
        [TestCase(103, 5, 105)]
        [TestCase(101, 5, 100)]
        public void WorkingWeightRoundsToNearestRoundingValue(decimal trainingMax, decimal roundingValue, decimal expectedValue)
        {
            var e = new A2SHyperTrophy()
            {
                TrainingMax = trainingMax,
                RoundingValue = roundingValue,
                Intensity = 1
            };

            factory.SetWorkingWeight(e);
            e.WorkingWeight.Should().Be(expectedValue);
        }

        //[TestCase(-3, 98)]
        [TestCase(-2, 98)]
        [TestCase(-1, 99)]
        [TestCase(0, 100)]
        [TestCase(1, 100.5)]
        [TestCase(2, 101)]
        [TestCase(3, 101.5)]
        [TestCase(4, 102)]
        [TestCase(5, 103)]
        //[TestCase(6, 103)]

        public void A2SHypertrophyTrainingMaxUpdates(int amrapResult, decimal expectedResult)
        {
            A2SHyperTrophy w1 = new A2SHyperTrophy
            {
                TrainingMax = 100m,
                RoundingValue = 2.5m,
                AmrapRepResult = amrapResult,
                AmrapRepTarget = 0
            };

            A2SHyperTrophy w2 = new A2SHyperTrophy
            {
                TrainingMax = 100m,
                RoundingValue = 2.5m
            };

            factory.ProgressExercise(w1, w2);
            expectedResult.Should().Be(w2.TrainingMax);
        }
    }
}
