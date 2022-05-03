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
        [Test]
        public void RepsIncrease()
        {
            w2.CurrentSets = 4;
            factory.ProgressExercise(w2, w3);

            Assert.True(w3.CurrentReps == 10);
            Assert.True(w3.CurrentSets == 3);
        }
    }
}
