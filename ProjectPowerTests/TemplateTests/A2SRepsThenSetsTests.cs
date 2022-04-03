using NUnit.Framework;
using ProjectPower.Areas.A2S_Program.Factories;
using ProjectPower.Areas.WorkoutCreation.Models.BaseWorkoutInformationService;
using ProjectPowerData.Folder.Models;
using System;

namespace ProjectPowerTests.TemplateTests
{
    [TestFixture]
    public class A2SRepsThenSetsTests
    {
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

            A2SHypertrophyFactory.Factory.ProgressExercise(w1, w2);

            Assert.True(w2.CurrentSets == 4);
        }
        [Test]
        public void RepsIncrease()
        {
            UpdateBasicWorkoutInformationModel model = new UpdateBasicWorkoutInformationModel
            {
                Reps = 8,
                Sets = 4,
            };
            w2.CurrentSets = 4;
            A2SHypertrophyFactory.Factory.ProgressExercise(w2, w2);

            Assert.True(w3.CurrentReps == 10);
            Assert.True(w3.CurrentSets == 3);
        }
    }
}
