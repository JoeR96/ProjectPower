using ProjectPowerData.Folder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPowerTests.Helpers
{
    internal static class A2SRepsThenSetsHelper
    {
        internal static A2SSetsThenReps ReturnBasicRepsThenSetsExercise(string guid)
        {
            A2SSetsThenReps repsThenSets = new A2SSetsThenReps();
            repsThenSets.StartingReps = 8;
            repsThenSets.StartingSets = 3;
            repsThenSets.CurrentReps = 8;
            repsThenSets.CurrentSets = 3;
            repsThenSets.RepIncreasePerSet = 2;
            repsThenSets.GoalReps = 8;
            repsThenSets.GoalSets = 4;
            repsThenSets.ExerciseMasterId = guid;
            return repsThenSets;
        }

    }
}
