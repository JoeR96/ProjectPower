using FluentAssertions;
using ProjectPowerData.Folder.Models;
using ProjectPower.Areas.A2S_Program.Factories;
using NUnit.Framework;

namespace ProjectPowerTests.TemplateTests
{
    [TestFixture]
    public class A2SHypertrophyTests
    {
        [Test]
        public void A2SHypertrophyWorkingWeightCalculates()
        {
        
            A2SHyperTrophy e = new A2SHyperTrophy
            {
                TrainingMax = 100m,
                Intensity = 0.7m,
                RoundingValue = 2.5m
            };

            A2SHypertrophyFactory.Factory.SetWorkingWeight(e);
            e.WorkingWeight.Should().Be(70m);
            Assert.AreEqual(70m,e.WorkingWeight);
        }      
        [Test]
        public void A2SHypertrophyTrainingMaxUpdates()
        {
            A2SHyperTrophy w1 = new A2SHyperTrophy
            {
                TrainingMax = 100m,
                RoundingValue = 2.5m,
                AmrapRepResult = 12,
                AmrapRepTarget = 9
            };

            A2SHyperTrophy w2 = new A2SHyperTrophy
            {
                TrainingMax = 100m,
                RoundingValue = 2.5m
            };
            
            A2SHypertrophyFactory.Factory.ProgressExercise(w1, w2);
            Assert.AreEqual(101.5m, w2.TrainingMax);
        }
    }
}
