using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectPower.Areas.A2S_Program.Helpers;
using ProjectPower.Areas.WorkoutCreation.Models.BaseWorkoutInformationService;
using ProjectPowerData.Folder.Models;
using System;

namespace ProjectPowerTests.TemplateTests
{
    [TestClass]
    public class A2SRepsThenSetsTests
    {
        A2SSetsThenReps w1;
        A2SSetsThenReps w2;
        A2SSetsThenReps w3;

        [TestInitialize]
        public void TestInitialize()
        {
            var id = Guid.NewGuid().ToString();
            w1 = Helpers.A2SRepsThenSetsHelper.ReturnBasicRepsThenSetsExercise(id);
            w2 = Helpers.A2SRepsThenSetsHelper.ReturnBasicRepsThenSetsExercise(id);
            w3 = Helpers.A2SRepsThenSetsHelper.ReturnBasicRepsThenSetsExercise(id);
        }
        [TestMethod]
        public void SetsIncrease()
        {
            UpdateBasicWorkoutInformationModel model = new UpdateBasicWorkoutInformationModel
            {
                Reps = 8,
                Sets = 3,
            };

            A2SHelper.ProgressSetsThenReps(model, w1, w2);

            Assert.IsTrue(w2.CurrentSets == 4);
        }
        [TestMethod]
        public void RepsIncrease()
        {
            UpdateBasicWorkoutInformationModel model = new UpdateBasicWorkoutInformationModel
            {
                Reps = 8,
                Sets = 4,
            };
            w2.CurrentSets = 4;
            A2SHelper.ProgressSetsThenReps(model, w2, w3);

            Assert.IsTrue(w3.CurrentReps == 10);
            Assert.IsTrue(w3.CurrentSets == 3);
        }
    }
}
