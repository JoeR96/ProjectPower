

using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectPower.Areas.A2S_Program.Helpers;
using ProjectPowerData.Folder.Models;

namespace ProjectPowerTests.TemplateTests
{
    [TestClass]
    public class A2SHypertrophyTests
    {
        [TestMethod]
        public void A2SHypertrophyWorkingWeightCalculates()
        {
            A2SHyperTrophy model = new A2SHyperTrophy();
            model.TrainingMax = 100m;
            model.Intensity = 0.7m;
            model.RoundingValue = 2.5m;

            decimal workingWeight = A2SHelper.WorkingWeight(model);
            Assert.AreEqual(workingWeight, 70m);
        }      
        [TestMethod]
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
            A2SHelper.ProgressA2SHypertrophy(w1, w2);
            Assert.AreEqual(101.5m, w2.TrainingMax);
        }
    }
}
