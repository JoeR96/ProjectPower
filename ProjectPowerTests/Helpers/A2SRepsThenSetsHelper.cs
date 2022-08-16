using ProjectPowerData.Folder.Models;

namespace ProjectPowerTests.Helpers
{
    internal static class A2SRepsThenSetsHelper
    {
        internal static A2SSetsThenReps CreateExercise(string id)
        {
            A2SSetsThenReps repsThenSets = new A2SSetsThenReps();
            repsThenSets.StartingReps = 8;
            repsThenSets.StartingSets = 3;
            repsThenSets.CurrentReps = 8;
            repsThenSets.CurrentSets = 3;
            repsThenSets.RepIncreasePerSet = 2;
            repsThenSets.GoalReps = 8;
            repsThenSets.GoalSets = 4;
            repsThenSets.ExerciseMasterId = id;
            return repsThenSets;
        }

    }
}
